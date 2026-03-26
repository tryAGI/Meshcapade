# CLAUDE.md — Meshcapade SDK

## Overview

Auto-generated C# SDK for [Meshcapade Me](https://meshcapade.com/) — 3D avatar creation, motion capture, and scene generation.
Covers avatar creation from images/measurements/scans/video/betas/SMPL, meshes, motions (search/blend), scenes, teams, credits, and subscriptions.

## Build & Test

```bash
dotnet build Meshcapade.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (obtained via OAuth2 password grant from Meshcapade Keycloak):

```csharp
var client = new MeshcapadeClient(accessToken); // MESHCAPADE_API_KEY env var
```

To obtain a token:
```bash
curl -X POST https://auth.meshcapade.com/realms/meshcapade-me/protocol/openid-connect/token \
  -d "grant_type=password&client_id=meshcapade-me&username=EMAIL&password=PASSWORD"
```

## Key Files

- `src/libs/Meshcapade/openapi.yaml` — **Manually maintained** OpenAPI spec (no public spec from Meshcapade)
- `src/libs/Meshcapade/generate.sh` — Runs autosdk on local spec (no download step)
- `src/libs/Meshcapade/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** — `openapi.yaml` was manually created from the `mcme` Python package (v1.2.1, API v1.24) and Meshcapade docs
- API uses JSON:API response format (`data.type`, `data.id`, `data.attributes`)
- Asset states: EMPTY → AWAITING_*_INPUT → PROCESSING → READY (or ERROR/CANCELED)
- Base URL includes API version: `https://api.meshcapade.com/api/v1`
