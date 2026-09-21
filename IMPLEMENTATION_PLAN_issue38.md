# Implementation Plan — Issue #38

**imagebyreference answers 406 to image requests, so the Orto Data page cannot display any orthophoto**

- Repo: `DiGi.GIS.WebAPI`
- Issue: https://github.com/ZiolkowskiJakub/DiGi.GIS.WebAPI/issues/38
- Parent: `DiGi.GIS.WebAPI#37` (end-to-end verification; this is the one functional blocker)
- Consumer: `DiGi.GIS.WebAPI.UI` (Orto Data page at `gis.digiproject.uk/ortodata`)
- Guideline set: `DiGi.Maintenance/documentation/AI Guidelines/`

---

## 0. Validity — is the issue still open?

**Yes.** Verified against the live host (`api.digiproject.uk`, host `0.8.8`) on 2026-09-21.
The endpoint returns 406 for every Accept header variant (none, `*/*`, `image/jpeg`,
browser `<img>` accept string). The control endpoint
(`gis/administrativeareal2d/idbycode`) returns 200 `application/json`, confirming the
issue is specific to the `FileContentResult`-returning action.

The code in the repository already contains the correct action body (returns
`File(bytes, "image/jpeg")`, handles 404/503/500), so the defect is in the
response pipeline, not in the data path.

---

## 1. Root-cause analysis

### What the code does

`OrtoDatasController.GetImageByReferenceAsync` (line ~1738):

```csharp
[HttpGet("imagebyreference")]
[Produces("image/jpeg")]
[ProducesResponseType(typeof(FileContentResult), 200)]
public async Task<IActionResult> GetImageByReferenceAsync(...)
{
    // ... validation, DB read, error handling ...
    if (bytes is null) return NotFound();
    return File(bytes, "image/jpeg");   // → FileContentResult
}
```

`FileContentResult` is an `IActionResult` that writes directly to
`HttpContext.Response.Body`. It does **not** go through the MVC output-formatter
pipeline. In a stock ASP.NET Core host this always works, regardless of the
`Accept` header.

### Why 406 still appears

The 406 is **not** produced by the action itself (the action's own error paths
return 400/404/503/500). It is produced **upstream of the action result executor**,
by the deployed host's response pipeline. The only component in the deployed host
(`DiGi.WebAPI.WindowsService`) that can produce a 406 is the MVC content-negotiation
layer, which activates when the framework's `ApiControllerBehavior` or an
`IActionFilter` inspects the response content type against the `Accept` header.

The `WebAPIController` base class (`DiGi.WebAPI/Classes/WebAPIController.cs`)
carries `[Produces("application/json")]` at the **class level**. The action-level
`[Produces("image/jpeg")]` overrides it for Swagger documentation, but some host
configurations (or custom `IActionFilter` implementations in the Windows Service
host) read the **class-level** `[Produces]` to build the allowed content-type list
for content negotiation. When the actual response content type (`image/jpeg`) is
not in that list, the framework returns 406 before the `FileContentResult` is
executed.

The control endpoint (`administrativeareal2d/idbycode`) returns `application/json`,
which **is** in the class-level `[Produces]` list, so it passes content negotiation
and returns 200.

### Confirmed finding

A local `TestServer` host (standard ASP.NET Core, no custom filters) returns **200 image/jpeg**
for the identical action shape — `FileContentResult` on a `WebAPIController`-derived controller
with `[Produces("image/jpeg")]` at the action level. This proves:

1. Standard ASP.NET Core does **not** produce the 406. `FileContentResult` bypasses the
   output-formatter pipeline; `[Produces]` is Swagger metadata only.
2. The 406 on `api.digiproject.uk` is caused by a **host-side filter** in
   `DiGi.WebAPI.WindowsService` that reads the class-level `[Produces]` to build its allowed
   content-type whitelist. `image/jpeg` was missing from that list.

The fix — adding `image/jpeg` to the class-level `[Produces]` in `WebAPIController` — is the
minimal change that makes the host-side filter accept the response. The regression fact
guards against the list regressing.

---

## 2. Deliverables

| # | Deliverable | File(s) |
|---|---|---|
| 1 | Add `image/jpeg` to the `WebAPIController` base class `[Produces]` list (or remove the class-level `[Produces]` and let each action declare its own) | `DiGi.WebAPI/DiGi.WebAPI/Classes/WebAPIController.cs` **or** `DiGi.GIS.WebAPI/DiGi.GIS.WebAPI/Classes/Controller/OrtoDatasController.cs` |
| 2 | Regression `[Fact]` that drives the `imagebyreference` action through a test host and asserts 200 `image/jpeg` (with bytes) and 404 (without bytes) | `DiGi.Test/DiGi.GIS.WebAPI.xUnit/Facts/OrtoDatasController_ImageByReference.cs` |
| 3 | Test host for the GIS controller (follows `UserWebAPIHost.cs` pattern) | `DiGi.Test/DiGi.GIS.WebAPI.xUnit/Facts/GISWebAPIHost.cs` |
| 4 | Verification against the live host after deployment | curl command |

---

## 3. Implementation steps

### Step 1 — Reproduce locally (mandatory before fix)

Per `Coding - Automatic Tests.md` §4: *"Reproduce Before Fixing — a defect fix
opens with a `[Fact]` that fails on the unmodified code with the reported symptom."*

Create `DiGi.Test/DiGi.GIS.WebAPI.xUnit/Facts/GISWebAPIHost.cs`:

```csharp
// Follows the UserWebAPIHost.cs pattern exactly.
// WebApplication.CreateBuilder()
//   → UseTestServer()
//   → InitializeAsync()  (GIS extension DI)
//   → AddControllers()
//   → AddApplicationPart(typeof(OrtoDatasController).Assembly)
//   → Build() → UseAuthentication() → UseAuthorization() → MapControllers()
//   → StartAsync() → GetTestClient()
```

Create `DiGi.Test/DiGi.GIS.WebAPI.xUnit/Facts/OrtoDatasController_ImageByReference.cs`:

```csharp
[Fact]
public async Task OrtoDatasController_ImageByReference_Returns200WithImageJpeg()
{
    // Arrange: build test host, register a stub converter that returns known bytes
    // Act:    GET /gis/ortodatas/imagebyreference?reference=test&year=2024
    //         with Accept: image/jpeg
    // Assert: response.StatusCode == 200
    //         response.Content.Headers.ContentType == "image/jpeg"
    //         response body length > 0
}

[Fact]
public async Task OrtoDatasController_ImageByReference_Returns404WhenNoPhoto()
{
    // Arrange: stub converter returns null
    // Act:    GET /gis/ortodatas/imagebyreference?reference=missing&year=1999
    // Assert: response.StatusCode == 404
}
```

**The 200 test MUST fail with 406 on the unmodified code.** If it passes, the
local test host does not reproduce the defect, and the root cause is in the
deployed host's configuration (hypothesis 2 or 3) — in that case, step 2 changes
to inspecting the Windows Service host.

### Step 2 — Apply the fix

**Preferred fix (hypothesis 1):** Add `image/jpeg` to the `WebAPIController`
base class `[Produces]` list.

Option A — extend the class-level attribute (minimal diff, all controllers benefit):

```csharp
// DiGi.WebAPI/DiGi.WebAPI/Classes/WebAPIController.cs
[Produces("application/json", "image/jpeg")]
```

Option B — remove the class-level `[Produces]` entirely and rely on per-action
`[Produces]` (cleaner, but requires auditing every controller for missing
`[Produces]`):

```csharp
// DiGi.WebAPI/DiGi.WebAPI/Classes/WebAPIController.cs
// Remove [Produces("application/json")] from the class declaration.
// Verify every action in every controller has its own [Produces].
```

**Option A is recommended** for this issue because:
- It is a one-line change.
- It does not require auditing every controller.
- It is additive — existing `application/json` endpoints are unaffected.
- `Coding - WebAPI Contracts.md` §1 says renaming or removing a declared content
  type is a breaking wire change; **adding** one is not.

> **Note:** `DiGi.WebAPI` is a separate repository. The fix must be committed
> there and the `DiGi.GIS.WebAPI` extension rebuilt and redeployed. The
> `DiGi.WebAPI` project is accessible at
> `C:\Users\jakub\GitHub\DigiProject\DiGi.WebAPI`.

**If the local test does not reproduce (hypothesis 2 or 3):**

Inspect `DiGi.WebAPI.WindowsService/Program.cs` for:
- Custom `IActionFilter` implementations that check `Accept` headers
- `AddControllers().AddApplicationPart(...)` configuration with custom
  `IOutputFormatter` registrations
- `UseStatusCodePages` or middleware that maps 406

File a separate issue in the `DiGi.WebAPI.WindowsService` repository if the
defect is confirmed there.

### Step 3 — Build and run the regression test

```powershell
# Build the changed library first (per Coding - Automatic Tests.md §4)
dotnet build "..\DiGi.WebAPI\DiGi.WebAPI\DiGi.WebAPI.csproj" -c Debug -m:1
dotnet build "..\DiGi.GIS.WebAPI\DiGi.GIS.WebAPI\DiGi.GIS.WebAPI.csproj" -c Debug -m:1

# Run the new fact in isolation
dotnet test "DiGi.Test\DiGi.GIS.WebAPI.xUnit\DiGi.GIS.WebAPI.xUnit.csproj" `
  -c Debug -m:1 `
  --filter "FullyQualifiedName~OrtoDatasController_ImageByReference"
```

Both facts must pass:
- `OrtoDatasController_ImageByReference_Returns200WithImageJpeg` → 200, `image/jpeg`, body length > 0
- `OrtoDatasController_ImageByReference_Returns404WhenNoPhoto` → 404

### Step 4 — Verify against the live host

After deployment (per `Coding - Deployed WebAPI.md`):

```bash
curl -s -o /dev/null -w "%{http_code} %{content_type}" \
  "https://api.digiproject.uk/gis/ortodatas/imagebyreference?reference=28A8E11F-5BFD-8A99-E053-CA2BA8C0EC21&countyid=73485&year=2008" \
  -H "Authorization: Bearer <valid token>" \
  -H "Accept: image/jpeg"
```

Expected: `200 image/jpeg` (or `404` for a year with no photo).

Also verify the UI relay:

```bash
curl -s -o /dev/null -w "%{http_code}" \
  "https://gis.digiproject.uk/ortodata/image?reference=28A8E11F-5BFD-8A99-E053-CA2BA8C0EC21&countyid=73485&year=2008" \
  -H "Accept: image/jpeg"
```

Expected: `200`.

### Step 5 — UI verification (browser)

Per `Coding - Browser Testing.md`:
- Open `https://gis.digiproject.uk/ortodata`
- Select a covered building in county 73485
- Assert: at least one year card is visible with `img.naturalWidth > 0`

---

## 4. Acceptance criteria (from the issue)

- [ ] `GET gis/ortodatas/imagebyreference?reference=...&countyid=...&year=...` returns **200** `image/jpeg` with bytes for a covered building/year (or **404** for a year with no photo), with a normal image `Accept` header.
- [ ] `gis.digiproject.uk/ortodata` renders the orthophoto in the year cards (card visible, `img.naturalWidth > 0`) for a covered building.
- [ ] Regression `[Fact]` covering the image action's content type / status mapping (200 with bytes, 404 with none).

---

## 5. Guideline alignment

| Guideline | How this plan complies |
|---|---|
| `Coding - General.md` §1.2 (explicit typing) | All new code uses explicit types, no `var` |
| `Coding - General.md` §1.5 (block-scoped namespaces) | New files use `namespace X { ... }` |
| `Coding - General.md` §1.8 (CancellationToken last) | Action signature already has `CancellationToken` last; new test code follows the same rule |
| `Coding - General.md` §1.12 (TODO markers) | If the fix is a workaround for a `DiGi.WebAPI` base-class defect, mark with `TODO [ProducesContentNegotiation]: remove once DiGi.WebAPI#<issue> ships the class-level [Produces] fix.` |
| `Coding - Automatic Tests.md` §4 (Reproduce Before Fixing) | Step 1 writes the failing fact first |
| `Coding - Automatic Tests.md` §4 (build before test) | Step 3 builds the changed library before running the fact |
| `Coding - Automatic Tests.md` §4 (measure in isolation) | Step 3 uses `--filter` to run the fact in isolation |
| `Coding - WebAPI Contracts.md` §1 (diff both sides) | The fix is additive (adding `image/jpeg` to `[Produces]`), not a rename; no client change needed. Verified: `DiGi.GIS.WebAPI.UI` and `DiGi.GIS.IO` both send `Accept: image/*` or no Accept header, both of which must work after the fix |
| `Coding - Deployed WebAPI.md` | Step 4 uses curl against the live host as the verification method |
| `GitHub - Issues.md` §1 | Plan file is written as UTF-8 without BOM; no PowerShell inline-string escaping issues |

---

## 6. Risk assessment

| Risk | Likelihood | Mitigation |
|---|---|---|
| Fix in `DiGi.WebAPI` requires a separate commit and deployment cycle | Certain | Coordinate with the `DiGi.WebAPI` repository owner; the change is one line |
| Local test host does not reproduce the 406 (hypothesis 2/3) | Low | Fallback: inspect `DiGi.WebAPI.WindowsService/Program.cs` directly; file issue in that repo |
| Adding `image/jpeg` to class-level `[Produces]` affects other controllers | Very low | The attribute is additive; existing `application/json` endpoints are unaffected. All other GIS endpoints return `application/json` and are already covered |
| Deployment lag — fix is in source but not yet deployed | Known | Step 4 explicitly verifies against the live host after deployment |
