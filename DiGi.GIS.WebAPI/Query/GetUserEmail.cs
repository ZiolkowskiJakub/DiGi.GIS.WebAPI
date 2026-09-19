using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace DiGi.GIS.WebAPI
{
    public static partial class Query
    {
        /// <summary>
        /// Validates a bearer token issued by the user extension and returns the identity it carries.
        /// <para>Denies by default: a missing <see cref="DiGi.WebAPI.Classes.SecurityKeyManager"/> or <see cref="DiGi.WebAPI.Classes.TokenRevocationStore"/> (a GIS-only host), a missing or malformed <c>Authorization</c> header, a failed signature or lifetime check, or a revoked <c>jti</c> all answer <c>null</c>. Callers map <c>null</c> to HTTP 401.</para>
        /// <para>Validation mirrors the user extension&apos;s <c>TokenValidationParameters</c> - issuer and audience unchecked, the signature checked against every key the manager holds, the lifetime checked - so both extensions agree on which tokens are valid.</para>
        /// </summary>
        /// <param name="securityKeyManager">The user extension&apos;s security key manager; <c>null</c> on a GIS-only host.</param>
        /// <param name="tokenRevocationStore">The user extension&apos;s token revocation store; <c>null</c> on a GIS-only host.</param>
        /// <param name="authorizationHeader">The value of the request&apos;s <c>Authorization</c> header, or <c>null</c>.</param>
        /// <returns>The <see cref="ClaimTypes.Email"/> the token carries, or <c>null</c> on every denial path.</returns>
        public static string? GetUserEmail(DiGi.WebAPI.Classes.SecurityKeyManager? securityKeyManager, DiGi.WebAPI.Classes.TokenRevocationStore? tokenRevocationStore, string? authorizationHeader)
        {
            // A GIS-only host registers neither singleton: there is no user session to validate, so this is a
            // 401 (nothing to authenticate against), not a 500.
            if (securityKeyManager is null || tokenRevocationStore is null)
            {
                return null;
            }

            string? BearerToken(string? header)
            {
                const string prefix = "Bearer ";
                if (string.IsNullOrWhiteSpace(header) || !header.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    return null;
                }

                return header[prefix.Length..].Trim();
            }

            string? token = BearerToken(authorizationHeader);
            if (string.IsNullOrWhiteSpace(token))
            {
                return null;
            }

            TokenValidationParameters parameters = new()
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKeyResolver = (_, _, _, _) =>
                {
                    List<SecurityKey> symmetricSecurityKeys = [];
                    foreach (DiGi.WebAPI.Classes.SecurityKey securityKey in securityKeyManager.SecurityKeys)
                    {
                        symmetricSecurityKeys.Add(new SymmetricSecurityKey(securityKey.GetBytes()));
                    }

                    return symmetricSecurityKeys;
                }
            };

            ClaimsPrincipal? principal;
            try
            {
                principal = new JwtSecurityTokenHandler().ValidateToken(token, parameters, out _);
            }
            catch (Exception)
            {
                // A failed signature, an expired token, or an unreadable manager all deny; every one of them is a 401.
                return null;
            }

            if (principal is null)
            {
                return null;
            }

            string? jti = principal.FindFirst(JwtRegisteredClaimNames.Jti)?.Value;
            if (!string.IsNullOrWhiteSpace(jti) && tokenRevocationStore.IsRevoked(jti))
            {
                return null;
            }

            string? email = principal.FindFirst(ClaimTypes.Email)?.Value;

            // A valid token that carries no usable identity cannot be attributed to a user, so it is a denial
            // (a 401) rather than a write recorded under an empty UserName - deny by default, fail closed.
            if (string.IsNullOrWhiteSpace(email))
            {
                return null;
            }

            return email;
        }
    }
}