## Repo snapshot

- Single-project .NET console app using SDK-style project: `Hello/Hello.csproj` (TargetFramework: net9.0).
- Entry point: `Hello/Program.cs` (simple top-level statement writing "Hello, World!").

## What an AI coding agent should know (short)

- This is a minimal, single-exe .NET 9 console application. Changes typically touch `Program.cs` or `Hello.csproj`.
- Build and run with the .NET SDK (dotnet CLI). Keep the `TargetFramework` unchanged unless explicitly migrating frameworks.

## Typical developer workflows (commands)

Use the project's folder (`Hello/`) as the working directory.

Build (Debug):
```pwsh
dotnet build Hello.csproj -c Debug
```

Run (Debug):
```pwsh
dotnet run --project Hello.csproj -c Debug
```

Publish (Release, single-file if needed):
```pwsh
dotnet publish Hello.csproj -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true
```

## Project-specific conventions and patterns

- Implicit global usings and nullable reference types are enabled in the project (`<ImplicitUsings>enable</ImplicitUsings>` and `<Nullable>enable</Nullable>` in `Hello.csproj`). Follow the project's nullability expectations when editing code.
- The repository keeps a single top-level console program (top-level statements in `Program.cs`) rather than an explicit `Main` method—prefer small, focused edits when extending behavior.

## What to avoid or preserve

- Do not rename the project or change the project GUID in `Hello.sln` without explicit instruction — this will disrupt solution loading in Visual Studio.
- Avoid adding build-time dependencies unless necessary. This project is intentionally minimal.

## Integration points & external dependencies

- There are no external NuGet dependencies declared. If adding packages, update `Hello.csproj` and ensure `dotnet restore` passes.

## Examples & quick edits

- To add a new console log in the current structure, edit `Hello/Program.cs` and keep changes succinct. Example change: replace the existing single line with a small method or extra Console.WriteLine calls.

## When tests or CI are added

- This repo currently has no test project. If you add tests, add a new xUnit/NUnit project and wire it into the solution (`.sln`) and CI.

## Helpful file references

- `Hello/Program.cs` — entry point and simplest example of top-level statements.
- `Hello/Hello.csproj` — project settings (TargetFramework, Nullable, ImplicitUsings).
- `Hello/Hello.sln` — solution file used by Visual Studio; keep stable.

If anything here is unclear or you want more detail (CI steps, recommended test harness, or migration guidance), tell me which area to expand.
