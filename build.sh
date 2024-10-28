#!/bin/bash
dotnet build IdentityValidator/IdentityValidator.csproj -c Release
dotnet IdentityValidator/bin/Release/net8.0/IdentityValidator.dll
