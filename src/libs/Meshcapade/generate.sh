#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

# Meshcapade has no public OpenAPI spec — openapi.yaml is manually maintained from mcme Python package & docs
autosdk generate openapi.yaml \
  --namespace Meshcapade \
  --clientClassName MeshcapadeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
