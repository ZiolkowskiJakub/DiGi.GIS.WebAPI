# Implementation Plan — Issue #14

**Issue:** `Claim endpoint cannot raise its command timeout, and now runs a DDL that may need it` — `ZiolkowskiJakub/DiGi.GIS.WebAPI#14`
**Labels:** `type: bug`, `priority: medium`, `ai: light`
**Date:** 2026-08-26 · **Re-verified:** 2026-08-27 (issue still open, no fix in any repo, code and live host unchanged, every plan claim re-checked)

## Execution status (2026-08-27)

| Step | Status |
|---|---|
| 0 — Branch sync | ✅ 0.8.8, clean, in sync |
| 1 — Controller change | ✅ committed `770c313` |
| 2 — Test | ✅ committed in `DiGi.Test` `e3456b0` |
| 3 — Build + API doc | ✅ zero warnings; API md hand-matched to generator output (DefaultDocumentation blocked by Smart App Control on this machine — regenerate on an unblocked machine to confirm byte-identical) |
| 4 — Test run | ⚠️ compiles against the new signature (pre-fix proof), but **cannot execute on this machine** — Smart App Control (enforce, `VerifiedAndReputablePolicyState=1`) blocks loading the unsigned test assembly (0x800711C7). Run on another machine / CI before shipping. |
| 5 — Commit | ✅ both repos, `0.8.8`, **not pushed** |
| 6 — Guideline sample | ✅ committed in `DiGi.Maintenance` `8fb9c87`; synced to every repo's `.agents/skills/` via `UpdateAgents.ps1` (one sync commit per repo, standard message, not pushed) |
| 7 — Deploy + migration | ⬜ pending explicit go-ahead |
| 8 — Task default | ⬜ owner decision |
| 9 — Close issue | ⬜ pending user approval |

---

## 1. Verdict: the issue is still valid — verified against the live host and the source

| Claim in the issue | Evidence |
|---|---|
| The endpoint exposes `count` and `claimtimeoutminutes` but no `commandTimeout` | **Live swagger of the deployed host (0.8.8.0, build 2026-08-26; re-confirmed 2026-08-27):** `POST /gis/ortodatas/nextbuilding2dreferences  params=[count, claimtimeoutminutes]` — while all six read siblings on the same controller expose `commandtimeout` (`estimatedcoveragefactor`, `estimatedcoveragefactors`, `countbycountyid`, `summariesbycountyids`, `subdivisionlinksbycountyid`, `queuesummariesbycountyids`). |
| "Unlike every other read endpoint on the controller" | `origin/0.8.8:DiGi.GIS.WebAPI/Classes/Controller/OrtoDatasController.cs` — every other action binds `[FromQuery(Name = "commandtimeout")] int commandTimeout = 600`; `NextBuilding2DReferencesAsync` does not, and its converter call omits `commandTimeout`, so the converter default of **60 s** applies. |
| The claim now runs DDL that may need more than 60 s | `DiGi.GIS.PostgreSQL` (0.8.8) `OrtoDatasPostgreSQLConverter.GetNextBuilding2DReferencesAsync` calls `Create.TableAsync_Building2DReference` (full DDL) before the claim statement, per the deployed #46 fix. On a queue table that predates `claimed_at`, the only costly statement is `CREATE INDEX idx_..._claimed_at` — an `ACCESS EXCLUSIVE` lock that must finish inside `commandTimeout`. Production queue: **7 447 931 rows** (per #46). |
| The converter already accepts `commandTimeout` | `GetNextBuilding2DReferencesAsync(int count = 100, int claimTimeoutMinutes = 30, int commandTimeout = 60, CancellationToken)` — threads it into both the DDL and the claim statement. **No `DiGi.GIS.PostgreSQL` change is required.** |
| #46 explicitly defers this to the issue | #46 comment (deployed-verification section): the migration "has to finish inside the claim's `commandTimeout`, which is 60 seconds and cannot be raised from the endpoint … Filed as ZiolkowskiJakub/DiGi.GIS.WebAPI#14". |

**Gap:** one controller parameter + one call-site argument. The converter, the DDL, and the tests that pin claim behaviour (`DiGi.Test/DiGi.GIS.PostgreSQL.xUnit/Facts/TableAsync_Building2DReference.cs`) already exist.

**Branch state (matters for where to implement):**

| Repo | Local checkout (2026-08-27) | Highest SemVer branch | Deployed |
|---|---|---|---|
| `DiGi.GIS.WebAPI` | **0.8.8**, in sync with `origin/0.8.8` (0/0), worktree clean | **0.8.8** | 0.8.8.0 |
| `DiGi.GIS.PostgreSQL` | 0.8.8, clean | 0.8.8 | — |
| `DiGi.Test` | 0.8.8, clean | 0.8.8 | — |

**All work happens on `0.8.8`**, where the controller still carries the defective signature (line 1061). On 0.8.7 the method was the older `NextBuilding2DReferences(count)`; implementing there would miss the endpoint as deployed.

---

## 2. Scope

**In scope (the issue):**
- `DiGi.GIS.WebAPI` — add a `commandtimeout` query parameter to `NextBuilding2DReferencesAsync` and thread it into the converter call.
- `DiGi.Test` — pin the new signature with an existing-style `[Fact]`.
- Regenerate `documentation/API/` (compile-time), commit.
- `DiGi.Maintenance` — update the stale controller sample in `Coding - PostgreSQL Distributed Queue Processing.md` §6 to the fixed signature.
- Deploy + live verification + issue closure.

**Out of scope (flagged, owner decision):**
- Raising any *default* timeout (see §4, Decision D1).
- `acknowledgebuilding2dreferences` — it now runs the DDL too (#46), but in the worker loop it always follows a successful claim, which has already run the DDL, so it never faces a first-build. Consistency candidate for a follow-up issue, not this one.
- `OrtoDatasTask` (server-side background task, `DiGi.GIS.WebAPI/Classes/BackgroundTask/OrtoDatasTask.cs` lines 73 and 231 on 0.8.8) — calls the converter with the 60 s default unattended. Optional step §8.

---

## 3. Implementation steps

### Step 0 — Branch sync (`GitHub - Branch Pull.md`) — **done, verified 2026-08-27**

All three repos are already on `0.8.8` with clean worktrees; `DiGi.GIS.WebAPI` verified in sync with its remote (`git rev-list --left-right --count 0.8.8...origin/0.8.8` → `0 0`). If the plan is picked up after other work, re-run the sync pipeline in all three repos before touching anything:

```bash
cd DiGi.GIS.WebAPI
git fetch --all --prune
git checkout 0.8.8
git pull origin 0.8.8
```

### Step 1 — Controller change (`DiGi.GIS.WebAPI/Classes/Controller/OrtoDatasController.cs`)

One method, `NextBuilding2DReferencesAsync` (0.8.8, line ~1056). Additive only — no route change, no rename, no removed parameter.

1. **Signature** — insert `[FromQuery(Name = "commandtimeout")] int commandTimeout = 60` between `claimTimeoutMinutes` and `CancellationToken`. Four parameters ≤ the 7-parameter single-line rule (`Coding - General.md` §1.6), and `CancellationToken` stays last (CA1068):

```csharp
public async Task<IActionResult> NextBuilding2DReferencesAsync([FromQuery(Name = "count")] int count = 100, [FromQuery(Name = "claimtimeoutminutes")] int claimTimeoutMinutes = 30, [FromQuery(Name = "commandtimeout")] int commandTimeout = 60, CancellationToken cancellationToken = default)
```

2. **Call site** — pass the value positionally (converter order is `count, claimTimeoutMinutes, commandTimeout, cancellationToken`), token by name per the rule:

```csharp
List<PostgreSQL.Classes.Building2DReference>? building2DReferences = await ortoDatasPostgreSQLConverter.GetNextBuilding2DReferencesAsync(count, claimTimeoutMinutes, commandTimeout, cancellationToken: cancellationToken);
```

3. **XML docs** — add `<param name="commandTimeout">` between the existing two `<param>` tags, mirroring the sibling wording and the actual default:

```xml
/// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 60 seconds.</param>
```

(`<param>` order mirrors signature order — `Coding - General.md` §1.8.)

4. **Logging** — extend the existing line, keeping the established style:

```csharp
Serilog.Modify.Log("Count provided: {Count}, ClaimTimeoutMinutes: {ClaimTimeoutMinutes}, CommandTimeout: {CommandTimeout}", count, claimTimeoutMinutes, commandTimeout);
```

5. **No new guard for `commandTimeout`.** `0` is a legal value ("disables the timeout", per the converter contract) and none of the six siblings validates the parameter — pass-through is the established wire behaviour on this controller. (A negative value would throw in Npgsql exactly as it does today on the six siblings; fixing that would be a separate, cross-endpoint change.)

**Wire-safety check (`Coding - WebAPI Contracts.md` §1, §5):** the change is additive — an absent parameter keeps the explicit default `60`, byte-identical to today's behaviour for every existing client. Consumers found by sweeping all of `DigiProject` for `nextbuilding2d*` (case-insensitive, `.cs/.js/.cshtml/.xaml`):

| Consumer | Call | Impact |
|---|---|---|
| `DiGi.GIS.WebAPI/Classes/BackgroundTask/OrtoDatasFromDatabasePostTask.cs:29` | endpoint via `UrlBuilder(path).AddParameter("count", 5)` | none — path unchanged, no new parameter sent |
| `DiGi.GIS.WebAPI/Classes/BackgroundTask/OrtoDatasTask.cs:73,231` | converter directly, defaults | none — defaults unchanged |
| `DiGi.GIS.UI/DiGi.GIS.UI.Application/Windows/MainWindow.xaml.cs:2789` | converter directly | none |

No renames, no removals, no front-end query strings to update.

### Step 2 — Test (`DiGi.Test/DiGi.GIS.WebAPI.xUnit/Facts/OrtoDatasController.cs`, branch 0.8.8)

The existing `Facts` partial class already pins this endpoint without a database (`OrtoDatasController_Validation_AnswersBadRequest`, `OrtoDatasController_Validation_AcceptsBoundary`, using `new PostgreSQL.Classes.OrtoDatasPostgreSQLConverter(null)`).

In `OrtoDatasController_Validation_AcceptsBoundary`, next to the existing `NextBuilding2DReferencesAsync(1, 1)` assertion, add:

```csharp
// The claim is the one endpoint whose DDL can need a real timeout, so the parameter must exist
// and must be accepted. Pre-fix this line does not compile - the signature is the defect.
Assert.IsNotType<BadRequestObjectResult>(await controller.NextBuilding2DReferencesAsync(1, 1, 600));
```

This is the "reproduce before fixing" artifact (`Coding - Automatic Tests.md` §4) in the form a signature-level defect allows: it fails (compile) on the unmodified 0.8.8 and passes after Step 1, with the same no-database style as its neighbours. The existing `NextBuilding2DReferencesAsync(10, 0)` / `(10, -1)` / `(1, 1)` calls keep compiling because the new parameter is optional.

The behaviour that actually matters — a claim whose index build outlives 60 s — cannot be unit-tested (it needs the 7.45 M-row production table); it is covered by live verification, §7, per `Coding - Deployed WebAPI.md` ("Manual curl checks only, never added to DiGi.Test").

### Step 3 — Build + regenerate API docs

```bash
dotnet build DiGi.GIS.WebAPI.slnx -c Release
```

- Zero warnings required (`Coding - General.md` §1.4).
- `documentation/API/DiGi.GIS.WebAPI/DiGi.GIS.WebAPI.Classes.md` regenerates on compile (`Coding - API Documentation.md`); it is git-tracked — commit the regenerated diff with the change so the doc shows the new signature.

### Step 4 — Test run

```bash
dotnet test DiGi.Test/DiGi.GIS.WebAPI.xUnit -c Release --filter "FullyQualifiedName~OrtoDatasController"
```

Plus the full `DiGi.GIS.WebAPI.xUnit` suite to catch anything that binds the old signature. The skipped integration fact `TableAsync_Building2DReference_Integration` is unchanged and remains opt-in (scratch database only).

### Step 5 — Commit

Single commit on `0.8.8`, e.g. `Expose commandtimeout on nextbuilding2dreferences (Fixes #14)` — matching the repo's existing `Fixes #N` commit convention (`d39ab7d`, `e6dd012`, `5618a9e`). Do **not** push unless asked; release via the standard `GitHub - Branch Synchronization.md` pipeline (merge `0.8.8` → `main`, bump to `0.8.9`, push both) when the owner is ready to ship.

### Step 6 — Guideline sync (`DiGi.Maintenance`)

`Coding - PostgreSQL Distributed Queue Processing.md` §6 ("WebAPI Controller & Client Endpoints") snapshots the defective code: its `NextBuilding2DReferencesAsync` sample shows only `count` and `claimTimeoutMinutes`, and the sample call omits `commandTimeout`. Update the sample to the fixed signature and pass `commandTimeout` in the call, so the guideline's own §7 checklist item — "Claim … accepts `count`, `claimTimeoutMinutes`, `commandTimeout`, `CancellationToken`" — holds in the documented pattern as well as in code. Guideline text is `ai: light` work (`GitHub - AI Issue Classification.md` §3); commit it in `DiGi.Maintenance` alongside the change it documents. If Decision D1 lands on `600`, amend the §3 standard signature in the same edit.

### Step 7 — Deploy + live verification (`Coding - Deployed WebAPI.md`)

1. Check the deployed `DiGi.GIS.PostgreSQL` build already carries the `commandTimeout` converter signature (0.8.8): `curl -s -H "key: <key>" "https://api.digiproject.uk/information/assemblies"`. If it does, redeploy **`DiGi.GIS.WebAPI.dll` only** (D3 changes no library). If it does not, deploy **`DiGi.GIS.WebAPI.dll` and `DiGi.GIS.PostgreSQL.dll` into `extensions\gis\` together** — the #46 comment documents that a half-deployment produces a `MissingMethodException`.
2. Confirm the new contract without writing anything:
   ```bash
   curl -s https://api.digiproject.uk/swagger/v1/swagger.json   # nextbuilding2dreferences now lists commandtimeout
   curl -s -H "key: <key>" "https://api.digiproject.uk/information/controllers" # build/hash carries the fix
   ```
   The key lives in `user files/WebAPI_Diagnostics.conf` (git-ignored) and travels in the `key` header, never the query string (`Coding - Deployed WebAPI.md` §2, `Coding - WebAPI Simple Authorization.md`).
3. **One-time production migration — a write, requires explicit go-ahead.** Two equivalent routes, pick one:
   - *Preferred (from #46):* run **"Refresh OrtoDatas"** scoped to a single already-queued county — the enqueue path runs the same DDL with a 600 s timeout and conflicts on `(county_id, reference)`, adding nothing new.
   - *Or, via this fix:* `curl -s -X POST "https://api.digiproject.uk/gis/ortodatas/nextbuilding2dreferences?count=1&commandtimeout=600"` — an unacknowledged claim returns to the queue after the 30-minute lease, so the call is self-cleaning.
4. Read-only health check afterwards: `curl -s "https://api.digiproject.uk/gis/ortodatas/queuesummariesbycountyids"` and check the server Serilog (`<install dir>\logs\log-<date>.txt` on the server — the log lives where the task ran, not on the editing machine, `Coding - PostgreSQL.md` §6).

### Step 8 — (Optional, owner decision) Server task default

If the unattended **"Bypass upload OrtoDatas from database"** task should survive a first-build on its own (today it claims with the 60 s default at `OrtoDatasTask.cs:73` and `:231`), pass an explicit value at both call sites, e.g. `commandTimeout: 600`, with a `TODO [QueueMigration]` marker stating the removal condition — "once every deployed queue table has run the `claimed_at` DDL at least once" — per the `TODO [MarkerName]` rule (`Coding - General.md` §1.12), the same pattern `TableAsync_Building2DReferencedObject` already uses for its 600 s default.

### Step 9 — Close the issue (`GitHub - Issues.md` §3)

Resolution comment (via `--body-file`, never inline markdown) covering: commit SHA + branch; changed files (`OrtoDatasController.cs`, `Facts/OrtoDatasController.cs`, regenerated API md); the `DiGi.Test` fact and test commands; live verification results (swagger before/after, migration call, queue summary). Then `gh issue close 14`.

---

## 4. Decisions

**D1 — Default value: `60` (recommended) vs `600`.**

| | `60` (recommended) | `600` |
|---|---|---|
| Existing callers | byte-identical behaviour (absent param → 60, as today) | silent change for `OrtoDatasTask`, `OrtoDatasFromDatabasePostTask`, `DiGi.GIS.UI` |
| The issue's ask | exactly it — "a caller has no way to raise it" | more than asked |
| Guideline standard | `Coding - PostgreSQL Distributed Queue Processing.md` §3 prescribes `commandTimeout = 60` for this method | would require amending the guideline's standard signature |
| Controller consistency | deviates from the six `= 600` siblings | matches them |
| Stuck-claim failure mode | fails fast (1 min) — better for the unattended task | hangs 10 min before failing |
| First-build migration | operator passes `&commandtimeout=600` once | automatic |

The one-shot migration is a deliberate, operator-driven event (and #46 already documents a 600 s route for it), while a stuck claim is a defect that should fail loudly and quickly — so preserving 60 and giving the caller the lever is the right split. If the owner prefers controller-wide consistency, `600` is a one-constant change on top of the same diff, and the Distributed Queue guideline's §3 standard signature must be amended in `DiGi.Maintenance` in the same change (Step 6).

**D2 — Wire name: `commandtimeout`.** Same lowercase name as the six siblings and as `count` / `claimtimeoutminutes` — no new spelling, nothing new to grep for in clients.

**D3 — No converter change.** `DiGi.GIS.PostgreSQL` already threads `commandTimeout` through DDL and claim; touching it would add deployment surface (`DiGi.GIS.PostgreSQL.dll` re-deploy, half-deployment risk) with no behaviour gain.

---

## 5. Guideline alignment checklist

- [x] **Issue premises verified against code and the live host before planning** (`GitHub - Issues.md` §2) — live swagger + `origin/0.8.8` source + converter + #46.
- [x] **Highest SemVer branch selected** for implementation: `0.8.8` (`GitHub - Branch Pull.md`).
- [x] **Additive wire change only**; all three consumers swept; no rename risk (`Coding - WebAPI Contracts.md` §1, §5).
- [x] **`CancellationToken` last; new optional parameter before it; token passed by name** (`Coding - General.md` §1.8, CA1068).
- [x] **≤ 7 parameters on one line** (4 parameters) (`Coding - General.md` §1.6).
- [x] **`commandTimeout` parameter standard** satisfied at the wire level; converter already assigns `NpgsqlCommand.CommandTimeout` (`Coding - PostgreSQL.md` §3).
- [x] **Distributed Queue checklist** §7 item "Claim … accepts `count`, `claimTimeoutMinutes`, `commandTimeout`, `CancellationToken`" becomes fully true end-to-end.
- [x] **Test in the existing `Facts` partial class, no-database style, fails (compile) pre-fix** (`Coding - Automatic Tests.md` §2, §4); live checks stay out of `DiGi.Test` (`Coding - Deployed WebAPI.md`).
- [x] **API markdown regenerated and committed** (`Coding - API Documentation.md`).
- [x] **Guideline sample updated with the code it documents** — `Coding - PostgreSQL Distributed Queue Processing.md` §6 sample fixed in `DiGi.Maintenance` (Step 6), so its §7 checklist item holds in the documented pattern too.
- [x] **Zero-warnings build** as the gate (`Coding - General.md` §1.4).
- [x] **Production write only with explicit go-ahead; logs read from the server, never from a `.conf`** (`Coding - Deployed WebAPI.md` §2, `Coding - PostgreSQL.md` §6).
- [x] **Optional task-side change carries a `TODO [Marker]` with an observable removal condition** (`Coding - General.md` §1.12).
- [x] **Structured resolution comment via `--body-file`** (`GitHub - Issues.md` §1, §3).
- [x] **Relative paths only in this document** (portability rule, `CLAUDE.md`).

---

## 6. Effort estimate

- Controller edit + XML docs + log line: ~10 lines touched in one file.
- Test: 1 assertion (+ comment) in one file.
- Guideline sample: 2 lines in one `DiGi.Maintenance` file.
- Build, test, API-doc regen, commit: routine.
- Deploy + live verification: the only non-trivial step (server redeploy + the one-time migration call).

Consistent with the `ai: light` label: one code repo changed (one method, one optional parameter, one test assertion) plus a two-line guideline sample.
