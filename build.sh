#!/usr/bin/env bash
set -e

CONFIGURATION=${1:-Release}

echo "[INFO] Restoring packages"
dotnet restore cybersource-rest-client-dotnet.sln

echo "[INFO] Building (${CONFIGURATION})"
dotnet build cybersource-rest-client-dotnet.sln -c ${CONFIGURATION} --no-restore -v minimal

echo "[INFO] Build complete: bin/${CONFIGURATION}/net48/cybersource-rest-client-dotnet.dll"
