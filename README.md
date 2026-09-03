# ProjectSignal

ProjectSignal is a prototype codename.

ProjectSignal is a headless operational command simulation about asymmetric perception, imperfect information, logistics, reconnaissance, deception, and adaptation.

"Humans fight an intelligence war against an unknown biological system. Aliens fight an evolutionary war against an industrial system."

## Status
Headless simulation design and Prototype 0 scaffolding.

The authoritative runtime target is a deterministic .NET console application. The existing Godot project is retained only as historical prototype material while useful domain behavior is migrated.

## Documentation
- [Documentation Index](docs/index.md)
- [ProjectSignal North Star](docs/north-star.md)
- [Prototype 0 Specification](docs/prototype-spec.md)
- [Implementation Status](docs/implementation-status.md)

## Runtime Layout

The standalone simulation lives under `src/`, tests live under `tests/`, and completed runs write inspectable JSON Lines records plus a Markdown after-action report under `artifacts/`.

## Run Prototype 0

```powershell
dotnet test ProjectSignal.sln
dotnet run --project src\ProjectSignal.Console\ProjectSignal.Console.csproj -- artifacts
```

The current console scenario writes its AAR to `artifacts/empty-corridor/aar.md`.
