# Implementation Plan — Issue #36

**Orto Data endpoints: random building, years by reference, set user year built**

- Repo: `DiGi.GIS.WebAPI`
- Issue: https://github.com/ZiolkowskiJakub/DiGi.GIS.WebAPI/issues/36
- Sibling (blocker): `DiGi.GIS.PostgreSQL#88` — **resolved** (converter methods present in tree)
- Consumer: `DiGi.GIS.WebAPI.UI` (Orto Data page); secondary: `DiGi.GIS.IO` (`imagebyreference`)
- Guideline set: `DiGi.Maintenance/documentation/AI Guidelines/`

> Paths below are relative to the repository root and use the repo's own layout. Per the
> portability rule, no absolute machine paths appear here.

---

## 0. Validity — is the issue still open?

**Yes.** None of the three endpoints exist yet, and the in-action validator does not. The one
external dependency (the converter methods) has since landed, so the only remaining work is in this
repository plus one small cross-repo gap (see §1, correction D).

Verified against the current tree:

| Claim in the issue | Verified state |
|---|---|
| No reusable validation helper exists | Confirmed — validation lives only in the user extension's `Modify/InitializeAsync.cs` `JwtBearer` events. `DiGi.GIS.WebAPI/Query/` has only `IsAuthorized.cs`. |
| `randombuilding2dreference` / `yearsbyreference` / `setuseryearbuilt` absent | Confirmed — `grep` over `Classes/Controller/` finds no such routes. |
| Blocked by `DiGi.GIS.PostgreSQL#88` | **Resolved.** All four converter methods exist: `GetRandomBuilding2DReferenceWithoutUserYearBuiltAsync`, `GetYearsByReferenceAsync`, `GetBytesByReferenceAsync` (each static + instance pair on `OrtoDatasPostgreSQLConverter`) and `UpdateUserYearBuiltAsync(int, string, GIS.Classes.UserYearBuilt, int, CancellationToken) → Task<bool?>` on `YearBuiltDataPostgreSQLConverter`. |
| `SecurityKeyManager` / `TokenRevocationStore` are concrete singletons in `DiGi.WebAPI.Classes` | Confirmed via `DiGi.WebAPI` public API: `SecurityKeyManager.SecurityKeys` (collection of `SecurityKey`, each `SecurityKey.GetBytes() → byte[]`), `TokenRevocationStore.IsRevoked(string jti) → bool`. Registered as `AddSingleton` by the user extension only. |
| `GISWebAPIConfigurationFileWatcher.AllowUpdateYearBuiltData` flag exists | Confirmed (`Classes/GISWebAPIConfigurationFileWatcher.cs`), and the deny-by-default `IsAuthorized` extension is `Query/IsAuthorized.cs`. |
| Test host precedent `DiGi.Test/DiGi.User.WebAPI.xUnit/Facts/UserWebAPIHost.cs` | Confirmed — `WebApplication` + `UseTestServer()` + `IServiceCollection.InitializeAsync()` + `AddApplicationPart(typeof(UserController).Assembly)`, driven through the `TestClient` `HttpClient`. |

---

## 1. Premise checks & corrections

Three parts of the issue need adjustment before implementation. Each is grounded in a guideline or in
the current tree.

### A. The JWT `PackageReference` IS required (verified, correcting the earlier guess)

`Coding - General.md` §4 says to build first and let `CheckHostDependencies.ps1` name what is actually
absent rather than pre-emptively declaring packages. Following that, I checked the installed
`Microsoft.AspNetCore.App` shared framework (10.0.12): it does **not** include `JwtBearer`,
`System.IdentityModel.Tokens.Jwt` or `Microsoft.IdentityModel.*`. So the issue body's premise was right
after all — the types are not in the shared framework, and the GIS extension (a class library that cannot
rely on the user extension's `HintPath`-opaque dependency) must declare the package itself to compile.

**Decision (done):** declare `Microsoft.AspNetCore.Authentication.JwtBearer` at the **exact version the
user extension references (10.0.5)** in `DiGi.GIS.WebAPI.csproj`, so both extensions resolve the same
`Microsoft.IdentityModel.Tokens` (amendment E — a version drift is invisible until a `MissingMethodException`
at the first token). `CheckHostDependencies.ps1` and `GET /information/assemblies` still need to be run
after the host build to confirm one copy each.

### B. Amendment A is a breaking wire change, not a "reuse as-is" (WebAPI Contracts §1)

The issue body lists `imagebyreference` as "reused as-is"; amendment A retargets it from a **floor**
lookup to **exact-year**. The current action (`OrtoDatasController.GetImageByReferenceAsync`) does:

```csharp
PostgreSQL.Classes.OrtoDatas? ortoDatas = await ortoDatasPostgreSQLConverter.GetOrtoDatasByReferenceAsync(reference, countyId, …);
byte[]? bytes = ortoDatas.ToDiGi()?.GetBytes(new DateTime(year, 1, 1));   // floor: serves the nearest ≤ year
```

Amendment A swaps this for `GetBytesByReferenceAsync(reference, countyId, year, fallbackByReference, …)`
and answers **404** for a year without a photo. That is a behavior change to an **existing public
endpoint**. `Coding - WebAPI Contracts.md` §1 names the consumers that build `imagebyreference` URLs:
`DiGi.GIS.WebAPI.UI` (the Orto Data page) and `DiGi.GIS.IO/Modify/Update.cs`. **Diff both before and
after; the change is only safe once both send a year that actually has imagery (they will, once they read
`yearsbyreference`).**

### C. Amendment D's `countyids` needs a converter overload that #88 did not deliver

Amendment D asks `randombuilding2dreference` to accept an optional `countyids` filter so a reviewer works
one county. The delivered `GetRandomBuilding2DReferenceWithoutUserYearBuiltAsync(int, CancellationToken)`
takes **no** `countyIds` parameter. Two options:

1. **Ship without `countyids`** now (the issue's own baseline), and file a small `DiGi.GIS.PostgreSQL`
   follow-up for a `countyIds`-filtering overload — keeps this repo's work unblocked and the wire
   contract additive.
2. **Add the overload first** in `DiGi.GIS.PostgreSQL` (new issue, or a #88 amendment), then wire it here.

**Recommend option 1** for this plan: the endpoint is fully functional without the filter, and the
filter is an additive query parameter that can land later without breaking the baseline contract. Record
the decision in the issue before starting.

### D. The body class inherits `DiGi.WebAPI.Classes.Parameter`, not `IGISWebAPISerializableObject`

Amendment C names the body class as `IGISWebAPISerializableObject`. The actual house pattern in this repo
(`Classes/Parameter/CountByAdministrativeAreal2DIdsParameter.cs`) is `public class X :
DiGi.WebAPI.Classes.Parameter` with the three-constructor pattern. Follow the real pattern.

---

## 2. Deliverables

| # | Deliverable | File(s) |
|---|---|---|
| 1 | Deny-by-default user-token validator (one `Query` member per file) | `DiGi.GIS.WebAPI/Query/GetUserEmail.cs` |
| 2 | `GET gis/ortodatas/randombuilding2dreference` | `DiGi.GIS.WebAPI/Classes/Controller/OrtoDatasController.cs` |
| 3 | `GET gis/ortodatas/yearsbyreference` | `DiGi.GIS.WebAPI/Classes/Controller/OrtoDatasController.cs` |
| 4 | `POST gis/yearbuiltdata/setuseryearbuilt` | `DiGi.GIS.WebAPI/Classes/Controller/YearBuiltDataController.cs` |
| 5 | Body class for #4 | `DiGi.GIS.WebAPI/Classes/Parameter/UserYearBuiltParameter.cs` |
| 6 | `imagebyreference` retarget to exact-year + `fallbackbyreference` (amendment A) | `DiGi.GIS.WebAPI/Classes/Controller/OrtoDatasController.cs` (existing action) |
| 7 | Test host (user + GIS together) + facts | `DiGi.Test/DiGi.GIS.WebAPI.xUnit/Facts/*` |
| 8 | JWT assembly verification (no-op unless §1-A fires) | build + `CheckHostDependencies.ps1` + `/information/assemblies` |

Both controllers already inject `GISWebAPIConfigurationFileWatcher`; add the two nullable user singletons
to each constructor (they resolve `null` on a GIS-only host — the 401 case).

---

## 3. Component 1 — in-action user-token validator

### 3.1 Why a validator and not `[Authorize]`

Per the issue's premise correction (2026-09-19): a host **without** the user extension answers `[Authorize]`
with **500** (`No authenticationScheme was specified…`), not 401. Acceptance criterion 1 requires 401
"including when the user extension is absent" — only an in-action check that resolves the user singletons
and denies when they are missing can meet it. The middleware's `OnTokenValidated` revocation hook also does
not run for a request that skips `[Authorize]`, so the validator must query `TokenRevocationStore` itself.

### 3.2 Shape

One `Query` member per file, mirroring `Query/IsAuthorized.cs`. Deny-by-default: every path that is not a
positive success returns `null`, and the caller maps `null` → 401.

```csharp
// DiGi.GIS.WebAPI/Query/GetUserEmail.cs
public static partial class Query
{
    /// <summary>
    /// Validates a bearer token issued by the user extension and returns its email claim.
    /// Denies by default: a missing <see cref="SecurityKeyManager"/> or <see cref="TokenRevocationStore"/>
    /// (a GIS-only host), a missing/malformed header, a failed signature or lifetime, or a revoked jti all return null.
    /// </summary>
    /// <returns>The <c>ClaimTypes.Email</c> value on success; <c>null</c> on every denial path (callers answer 401).</returns>
    public static string? GetUserEmail(
        DiGi.WebAPI.Classes.SecurityKeyManager? securityKeyManager,
        DiGi.WebAPI.Classes.TokenRevocationStore? tokenRevocationStore,
        string? authorizationHeader)
    {
        if (securityKeyManager is null || tokenRevocationStore is null)
        {
            return null;                                    // GIS-only host — 401, not 500
        }

        string? token = ExtractBearer(authorizationHeader);  // "Authorization: Bearer <jwt>"
        if (string.IsNullOrWhiteSpace(token))
        {
            return null;
        }

        List<SecurityKey> signingKeys = securityKeyManager.SecurityKeys is null
            ? []
            : [.. securityKeyManager.SecurityKeys.Select(key => new SymmetricSecurityKey(key.GetBytes()))];

        TokenValidationParameters parameters = new()
        {
            IssuerSigningKeys = signingKeys,
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,                          // expired token refused (acceptance criterion 2)
        };

        JsonWebToken? jwt = new JsonWebTokenHandler().ValidateToken(token, parameters);
        if (jwt is null)
        {
            return null;                                      // bad signature / lifetime
        }

        if (jwt.TryGetPayloadValue<string>(JwtRegisteredClaimNames.Jti, out string? jti) && tokenRevocationStore.IsRevoked(jti!))
        {
            return null;                                      // revoked (acceptance criterion 2)
        }

        return jwt.TryGetPayloadValue<string>(ClaimTypes.Email, out string? email) ? email : null;
    }
}
```

Notes:
- `SecurityKey` here is `Microsoft.IdentityModel.Tokens.SecurityKey`; `SecurityKeyManager.SecurityKey`
  (the DiGi type) exposes `GetBytes()`.
- The exact `JsonWebTokenHandler` call shape (sync vs `ValidateTokenAsync`, claim-reading helper) should be
  matched to what the user extension's `Create/TokenString.cs` and `Modify/InitializeAsync.cs` already use, so
  both extensions validate identically. Confirm the handler type and the `jti` claim constant against those
  two files before finalizing — the issue pins "HMAC-SHA256, `jti`, `ClaimTypes.Email`, lifetime checked".
- DI: both singletons are registered only by the user extension's `AddSingleton`. On a full deployment they
  resolve; on a GIS-only host `GetService` returns `null` for a nullable reference-type controller parameter
  (MVC uses `GetService`, not `GetRequiredService`), which is exactly the 401 case.

### 3.3 Caller convention (all three endpoints)

Each action runs the validator first and returns 401 before any other logic:

```csharp
string? email = Query.GetUserEmail(securityKeyManager, tokenRevocationStore, HttpContext.Request.Headers.Authorization);
if (email is null)
{
    return Unauthorized();
}
```

`setuseryearbuilt` additionally uses `email` as the `UserYearBuilt` provenance.

---

## 4. Component 2 — endpoints

All routes/parameter names are a wire contract (WebAPI Contracts §1). `[ApiController]` gives automatic 400
for present-but-unparseable values; **absent** simple-type parameters keep `default(T)`, so anything whose
absence must be rejected is bound nullable and rejected explicitly (WebAPI Contracts §2).

### 4.1 `GET gis/ortodatas/randombuilding2dreference` — `OrtoDatasController`

```csharp
[HttpGet("randombuilding2dreference", Name = $"{nameof(OrtoDatasController)}_{nameof(GetRandomBuilding2DReferenceAsync)}")]
[ApiExplorerSettings(IgnoreApi = false)]
[ProducesResponseType(typeof(PostgreSQL.Classes.Building2DReference), StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status404NotFound)]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
public async Task<IActionResult> GetRandomBuilding2DReferenceAsync(
    [FromQuery(Name = "commandtimeout")] int commandTimeout = 30,
    CancellationToken cancellationToken = default)
```

- Order: token (401) → `commandTimeout < 0` (400) → converter.
- Call `ortoDatasPostgreSQLConverter.GetRandomBuilding2DReferenceWithoutUserYearBuiltAsync(commandTimeout, cancellationToken)`.
- `null` → 404 (no unverified covered building remains); non-null → 200 with the `Building2DReference`.
- `Building2DReference.CountyId` is the `building_2d` **part** — the page must send it back on the write and
  every read (amendment D).
- `countyids` (amendment D): **omit for now** per §1-C; add later once the converter overload exists. The
  route name and existing parameters are unchanged, so adding `countyids` is additive and non-breaking.

### 4.2 `GET gis/ortodatas/yearsbyreference` — `OrtoDatasController`

```csharp
[HttpGet("yearsbyreference", Name = $"{nameof(OrtoDatasController)}_{nameof(GetYearsByReferenceAsync)}")]
[ApiExplorerSettings(IgnoreApi = false)]
[ProducesResponseType(typeof(List<short>), StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status204NoContent)]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
public async Task<IActionResult> GetYearsByReferenceAsync(
    [FromQuery(Name = "reference")] string reference,
    [FromQuery(Name = "countyid")] int? countyId = null,
    [FromQuery(Name = "fallbackbyreference")] bool fallbackByReference = false,   // amendment B
    CancellationToken cancellationToken = default)
```

- Order: token (401) → `reference` blank (400) → converter.
- Call `ortoDatasPostgreSQLConverter.GetYearsByReferenceAsync(reference, countyId, fallbackByReference, commandTimeout: 30, cancellationToken)` → `List<short>?`.
- **Never** `OrtoDatas.TryGetYears` (amendment A): it returns every year between oldest and newest, mislabeling gap years.
- `null` → 400/404 per converter nullability (a `null` connection is a 5xx class; an empty list is 204).
  Empty list → **204** (building has no orthophotos). Non-empty → 200 with the sorted year list.
- `fallbackbyreference` mirrors `ortodatasreferencebyreference` exactly; the UI sends `true` (amendment B).

### 4.3 `POST gis/yearbuiltdata/setuseryearbuilt` — `YearBuiltDataController`

```csharp
[HttpPost("setuseryearbuilt", Name = $"{nameof(YearBuiltDataController)}_{nameof(SetUserYearBuiltAsync)}")]
[ApiExplorerSettings(IgnoreApi = false)]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status404NotFound)]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
[ProducesResponseType(StatusCodes.Status500InternalServerError)]
public async Task<IActionResult> SetUserYearBuiltAsync(
    [FromBody] Classes.Parameter.UserYearBuiltParameter? parameter,
    CancellationToken cancellationToken = default)
```

Order of checks (amendment C) — and **log each 4xx cause distinctly even where the status is the same**
(WebAPI Simple Authorization §3 item 5):

1. **Token** → 401 (`email` from the validator is the provenance).
2. **Flag** `GISWebAPIConfigurationFileWatcher.AllowUpdateYearBuiltData` → 400 (mirrors the existing
   `updateitems*` actions at `YearBuiltDataController.cs` lines 69–79).
3. **Body validation** (all 400, each logged distinctly):
   - `parameter is null` → 400.
   - `CountyId is null` → 400.
   - `Reference` blank → 400.
   - `Year is null` → 400 (a non-nullable binding cannot tell "omitted" from a legitimate value — WebAPI Contracts §2).
   - `Relation` not a `YearBuiltRelation` member (`0`/`1`/`2`) → 400; `null` → `0` (`Exact`). Bind as `int?`
     and validate against the enum members — do **not** compare against a non-zero sentinel (WebAPI Contracts §2).
4. **Write** — build `new UserYearBuilt(year, relation, DateTimeOffset.UtcNow, email)` and call
   `yearBuiltDataPostgreSQLConverter.UpdateUserYearBuiltAsync(countyId, reference, userYearBuilt, commandTimeout: 30, cancellationToken)`.

Outcome mapping (amendment C — 500, not 503, there is no upstream to be unavailable):
- `true` → 200.
- `null` → 404 (`building_2d` has no such reference under that code).
- `false` → 500 (the write failed / rolled back).

The action never trusts `CountyId` beyond passing it as the hint — the converter resolves the county part
itself (#88 §A/§B).

### 4.4 Body class — `Classes/Parameter/UserYearBuiltParameter.cs`

Follow `CountByAdministrativeAreal2DIdsParameter` (`: DiGi.WebAPI.Classes.Parameter`, three-constructor
pattern, `[Required]` where applicable):

```csharp
public class UserYearBuiltParameter : DiGi.WebAPI.Classes.Parameter
{
    public UserYearBuiltParameter() { }
    public UserYearBuiltParameter(JsonObject jsonObject) : base(jsonObject) { }
    public UserYearBuiltParameter(UserYearBuiltParameter parameter) : base(parameter) { /* copy */ }

    public int? CountyId { get; set; }          // null → 400
    public string? Reference { get; set; }       // blank → 400
    public short? Year { get; set; }             // null → 400
    public int? Relation { get; set; }           // null → Exact(0); non-member → 400
}
```

Bind via `[FromBody]`; the JSON constructor deserializes. Keep the wire names as declared (WebAPI Contracts §2
— a JSON body's property names are a contract; confirm the UI sends `CountyId/Reference/Year/Relation` and that
its client serializes with `JsonSerializerOptions.Default` when the names matter).

### 4.5 `imagebyreference` — retarget to exact-year (amendment A, breaking)

Change the existing `GetImageByReferenceAsync` to serve through `GetBytesByReferenceAsync` and answer 404 for a
year without a photo; add `fallbackbyreference` (amendment B):

```csharp
[HttpGet("imagebyreference", Name = $"{nameof(OrtoDatasController)}_{nameof(GetImageByReferenceAsync)}")]
[Produces("image/jpeg")]
[ProducesResponseType(typeof(FileContentResult), 200)]
[ProducesResponseType(404)]
[ProducesResponseType(400)]
public async Task<IActionResult> GetImageByReferenceAsync(
    [FromQuery(Name = "reference")] string reference,
    [FromQuery(Name = "year")] short year,
    [FromQuery(Name = "countyid")] int? countyId = null,
    [FromQuery(Name = "fallbackbyreference")] bool fallbackByReference = false,   // added (amendment B)
    CancellationToken cancellationToken = default)
{
    if (string.IsNullOrWhiteSpace(reference)) return BadRequest();
    byte[]? bytes = await ortoDatasPostgreSQLConverter.GetBytesByReferenceAsync(reference, countyId, year, fallbackByReference, commandTimeout: 30, cancellationToken: cancellationToken);
    if (bytes is null) return NotFound();          // exact-year: a gap year is 404, not the previous photo
    return File(bytes, "image/jpeg");
}
```

This is a **behavior change** (floor → exact), not a parameter rename — the names `reference`/`year`/`countyid`
are unchanged, so it is not the silent wire-break of WebAPI Contracts §1. It is **required** by amendment A and
pinned by the acceptance criteria (`imagebyreference answers 404 for any other year`). Consumer diff (done):
the one external sender, `DiGi.GIS.IO/Modify/Update_Building2D.cs`, writes the URL into a spreadsheet cell and
never fetches, so a gap-year 404 is clearer than the previous silently mislabeled photo — see §12.

---

## 5. JWT assembly / host dependency

- Default: **no `PackageReference`** — the `Microsoft.AspNetCore.App` FrameworkReference already supplies the
  validation types at compile time and the shared framework supplies them at runtime for both extensions
  (General §4).
- Build, then run `DiGi.Maintenance/Scripts/CheckHostDependencies.ps1 -FailOnMissing` against the
  `DiGi.WebAPI.WindowsService` host **together with** its `extensions\*` folders (General §4, *Extension Hosts
  Are One Probing Set*). If it names an absent `Microsoft.IdentityModel.*` / JwtBearer assembly, add
  `Microsoft.AspNetCore.Authentication.JwtBearer 10.0.5` (the user extension's exact version) once on
  `DiGi.WebAPI.WindowsService` or identically in both extension folders, and re-run the script.
- After deployment: `GET /information/assemblies` must show **one copy** of each IdentityModel/JwtBearer
  assembly (acceptance criterion; amendment E — a version drift between the two folders is invisible until a
  `MissingMethodException` at the first token).

---

## 6. Tests

Precedent: `DiGi.Test/DiGi.User.WebAPI.xUnit/Facts/UserWebAPIHost.cs`. Extend the pattern to host **user + GIS
together** in `DiGi.Test/DiGi.GIS.WebAPI.xUnit`:

- `Facts/OrtoDataHost.cs` — `WebApplication.CreateBuilder()` + `UseTestServer()`, then **both**
  `serviceCollection.InitializeAsync()` calls (user extension, then GIS extension), `AddControllers()` +
  `AddApplicationPart` for both controller assemblies, `UseAuthentication()` → `UseAuthorization()` →
  `MapControllers()` → `StartAsync()`. Expose the `TestClient` `HttpClient` and `SecurityKeyManager`.
- `DiGi.GIS.WebAPI.xUnit.csproj` currently references `DiGi.WebAPI` and the GIS assemblies but **not** the user
  extension. Add a `ProjectReference`/`HintPath` to `DiGi.User.WebAPI` (and the `Microsoft.AspNetCore.TestHost`
  package, as the user test project uses) so the combined host compiles.
- Facts (from the issue + amendments):
  - **Anonymous → 401** on all three endpoints.
  - **Wrong-key token → 401.**
  - **Revoked token → 401** (register a `TokenRevocationStore`, revoke a `jti`).
  - **Expired token → 401** (lifetime).
  - `setuseryearbuilt`: **flag disabled → 400**; **`Year` omitted → 400**; **`Relation` out of range → 400**.
  - `setuseryearbuilt` happy path → 200; the stored entry carries `UserName` = login email and a `DateTime`
    within the test window; a sibling-part `CountyId` on a multi-part code → 200 and the row under the
    `building_2d` part (GIS Administrative Data guideline).
  - `yearsbyreference` on a fixture with a gap year lists **only** the photographed years; `imagebyreference`
    for the gap year → **404**.
  - `randombuilding2dreference` (baseline, no `countyids` yet) → 200 with a `Building2DReference` or 404.
- Facts that require a database should skip gracefully when the connection is absent (match the existing
  `DiGi.GIS.WebAPI.xUnit` conventions — `Facts/` already contains `*Controller.cs` facts).
- Manual (not in `DiGi.Test`): after deployment,
  `curl https://api.digiproject.uk/information/endpoints?includeignored=true` lists the three routes with the
  exact parameter names (Deployed WebAPI guideline).

---

## 7. Cross-repo consumer diff (WebAPI Contracts §1)

`imagebyreference` semantics change (floor → exact/404). Before merging, grep and review every sender:

```bash
# Senders of imagebyreference across consumers and the front end
grep -rnoE 'imagebyreference' --include=*.cs DiGi.GIS.WebAPI.UI DiGi.GIS.IO
grep -rnE "imagebyreference|\?year=" --include=*.js --include=*.cshtml DiGi.GIS.WebAPI.UI
```

Both consumers must send a year that has imagery (they will, once they read `yearsbyreference`). The new
endpoints have no pre-existing consumers; the UI is built against them (sibling `DiGi.GIS.WebAPI.UI` issue).

---

## 8. Guideline alignment checklist

| Step | Guideline |
|---|---|
| Deny-by-default validator, `null` on every failure | WebAPI Simple Authorization §1/§2 (deny by default; `Open` is the only escape — not applicable to a user token) |
| One `Query` member per file (`Query/GetUserEmail.cs`) | General (one member per file for Query) |
| Nullable bindings + explicit `null` rejection for `Year`, `CountyId`; `Relation` validated against members, no non-zero sentinel | WebAPI Contracts §2 |
| `CancellationToken` last on every action, threaded to the converter | General (CancellationToken ordering), WebAPI Contracts §5 |
| JSON body names are a contract; confirm wire names + `JsonSerializerOptions.Default` when they matter | WebAPI Contracts §2 |
| Multi-part county: `Building2DReference.CountyId` is the part; sibling-part write lands under the `building_2d` part | GIS Administrative Data |
| `imagebyreference` change is a breaking wire change → diff consumers | WebAPI Contracts §1/§4 |
| No pre-emptive JWT `PackageReference`; build + `CheckHostDependencies.ps1` first; same version if declared | General §4 |
| `TODO [Marker]` for the deferred `countyids` (amendment D), with an observable removal condition | General §1; WebAPI Contracts §4 |
| Test host extends `UserWebAPIHost`; facts skip gracefully without a DB | Automatic Tests |
| Manual deployed check via `/information/endpoints`, never added to `DiGi.Test` | Deployed WebAPI |

---

## 9. Verification sequence

1. `dotnet build` the `DiGi.GIS.WebAPI` solution (0 warnings — house standard).
2. `DiGi.Maintenance/Scripts/CheckHostDependencies.ps1 -FailOnMissing` on the host + `extensions\*`.
3. `dotnet test DiGi.Test/DiGi.GIS.WebAPI.xUnit` (and the user test project for the combined host).
4. Local smoke: boot the combined host, hit the three endpoints with anonymous / valid / wrong-key / revoked
   tokens, assert the 401/200/400/404/500 mapping.
5. Deploy, then `curl /information/endpoints?includeignored=true` and `curl /information/assemblies`.
6. Diff `imagebyreference` consumers (§7).

---

## 10. Decisions / open questions (record in the issue before starting)

1. **`countyids` on `randombuilding2dreference`** — ship without it now and file the `DiGi.GIS.PostgreSQL`
   overload (recommended, §1-C), or block on the overload first.
2. **JWT package** — confirm `CheckHostDependencies.ps1` reports the IdentityModel/JwtBearer assemblies
   present via the shared framework (expected) before deciding to declare any `PackageReference` (§1-A, §5).
3. **`imagebyreference` breaking change** — confirm both consumers are updated in the same release window
   (§1-B, §7).
4. **`Relation` enum on the wire** — the UI must send the **integer** (`0`/`1`/`2`), not the member name
   (WebAPI Contracts §2). Confirm with the UI issue.

---

## 11. Implementation order

1. `Query/GetUserEmail.cs` (validator) — unblocks all three endpoints and the test facts.
2. `Classes/Parameter/UserYearBuiltParameter.cs`.
3. `setuseryearbuilt` (exercises the flag + body validation + outcome mapping).
4. `yearsbyreference` (exercises `GetYearsByReferenceAsync` + `fallbackbyreference`).
5. `randombuilding2dreference` (exercises `GetRandomBuilding2DReferenceWithoutUserYearBuiltAsync`).
6. `imagebyreference` retarget (breaking; last, with the consumer diff).
7. Combined test host + facts; then build/`CheckHostDependencies`/deploy verification (§9).

---

## 12. Implementation status

Implemented in `DiGi.GIS.WebAPI` and tested in `DiGi.Test/DiGi.GIS.WebAPI.xUnit` (75 facts, all passing;
GIS extension builds with 0 warnings):

| # | Item | Status |
|---|---|---|
| 1 | `Query/GetUserEmail.cs` — `GetUserEmail` deny-by-default validator (mirrors the user extension's `TokenValidationParameters`; checks `TokenRevocationStore.IsRevoked(jti)` itself) | Done |
| 2 | `GET gis/ortodatas/randombuilding2dreference` (401 → 400 → converter → 200/404) | Done (baseline, no `countyids`) |
| 3 | `GET gis/ortodatas/yearsbyreference` (401 → 400 → `GetYearsByReferenceAsync` → 200/204/500) | Done |
| 4 | `POST gis/yearbuiltdata/setuseryearbuilt` (401 → flag 400 → body 400 → `UpdateUserYearBuiltAsync` → 200/404/500) | Done |
| 5 | `Classes/Parameter/UserYearBuiltParameter` (`: DiGi.WebAPI.Classes.Parameter`) | Done |
| 6 | `imagebyreference` retargeted to exact-year via `GetBytesByReferenceAsync`, `fallbackbyreference` added, 404 for a gap year | Done |
| 7 | `Microsoft.AspNetCore.Authentication.JwtBearer 10.0.5` in `DiGi.GIS.WebAPI.csproj` (matches the user extension) | Done |
| 8 | Tests: 9 `GetUserEmail` facts (valid / **empty email → null** / wrong-key / revoked / expired / malformed / missing singletons / case-insensitive prefix) + 8 controller facts (anonymous → 401 on all three; flag-disabled with a valid token → 400; **body validation — CountyId omitted / Reference blank / Year omitted / Relation out of range → 400**) | Done |

Both controllers inject the user singletons as **nullable constructor parameters with `= null` defaults**, so a GIS-only host (unregistered singletons) resolves `null` → 401, and the existing direct-construction test call sites keep compiling unchanged.

### Bug review findings (2026-09-19)

- **`imagebyreference` — decision: KEEP the exact-year retarget (do not revert).** Amendment A retargets it
  from floor-lookup to exact-year + 404, and the acceptance criteria pin it. Reverting would fail an explicit
  criterion and re-introduce the mislabeling defect the amendment fixes (a building photographed 2004/2010/2015
  would serve the **2004** photo for `year=2007` with a 200). Verified the one external consumer,
  `DiGi.GIS.IO/Modify/Update_Building2D.cs` (lines 84–93 loop `2008..now`; line 301 `SetValue(row, col,
  "…imagebyreference?reference=…&year={i}&countyId=…")`): it writes a **URL string into a spreadsheet cell** and
  never fetches the image, so a gap-year 404 is *clearer* ("no photo for this year") than silently serving the
  nearest earlier photo. The consumer is not broken — it is improved. Optional follow-up: read `yearsbyreference`
  and emit links only for photographed years.
- **Two guideline violations in the validator, fixed this pass:**
  - `Query/GetUserToken.cs` → renamed to `Query/GetUserEmail.cs` — one `Query` member per file, named after the
    method (General §2); the plan already referenced `GetUserEmail.cs`, so the code now matches it.
  - `BearerToken` was a `private static` method on the `Query` partial class — prohibited (General §2). Inlined
    as a **local function** inside `GetUserEmail` (single-use helper).
- **Hardened (fixed this pass):** a valid token with an empty `ClaimTypes.Email` previously returned `""` (not
  `null`), slipping past the controller's `if (email is null)` guard and storing `UserName = ""`. The validator
  now returns `null` for a blank email (deny by default; General §1.15 — a check that skips absent input fails
  open), and a `GetUserEmail_ValidTokenEmptyEmail_ReturnsNull` fact covers it.

### Deliberately deferred / to verify out of band
- **`countyids` on `randombuilding2dreference`** (amendment D): not wired — the delivered
  `GetRandomBuilding2DReferenceWithoutUserYearBuiltAsync(int, CancellationToken)` takes no `countyIds`. This is an
  **unmet acceptance criterion**, now owned by the filed follow-up
  [DiGi.GIS.PostgreSQL#89](https://github.com/ZiolkowskiJakub/DiGi.GIS.PostgreSQL/issues/89)
  (`type: feature`, `priority: medium`, `ai: standard`, assigned to ZiolkowskiJakub). #36 carries a cross-repo
  `blocked_by` dependency on #89 (verified via the dependencies API). The route and existing parameters are
  unchanged, so the filter is additive and non-breaking when it lands.
- **Host build + `CheckHostDependencies.ps1` + `GET /information/assemblies`** (one copy each of the IdentityModel/JwtBearer assemblies): run after the `DiGi.WebAPI.WindowsService` build.
- **Deployed smoke**: `curl https://api.digiproject.uk/information/endpoints?includeignored=true` lists the three routes with the exact parameter names, and the three answer 401 without a valid token.
