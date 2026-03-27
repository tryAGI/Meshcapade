# Authentication

The Meshcapade SDK uses Bearer token authentication. Access tokens are obtained via OAuth2 password grant from the Meshcapade Keycloak instance.

## Obtaining an Access Token

Request an access token from the Meshcapade Keycloak endpoint:

```bash
curl -X POST https://auth.meshcapade.com/realms/meshcapade-me/protocol/openid-connect/token \
  -d "grant_type=password&client_id=meshcapade-me&username=YOUR_EMAIL&password=YOUR_PASSWORD"
```

The response contains an `access_token` field that you pass to the SDK.

## Basic Usage

```csharp
using Meshcapade;

var client = new MeshcapadeClient(apiKey: Environment.GetEnvironmentVariable("MESHCAPADE_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `MESHCAPADE_API_KEY` | Your Meshcapade OAuth2 access token |
