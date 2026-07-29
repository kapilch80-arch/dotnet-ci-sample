# dotnet-ci-sample

A minimal **.NET Core (C#)** solution used to test automated CI bootstrapping.

- `src/TempConverter` — a small library that converts temperatures between
  Celsius, Fahrenheit, and Kelvin.
- `tests/TempConverter.Tests` — xUnit tests for the library.

There is intentionally **no CI workflow** in this repo — it's meant to have one
generated and added via a pull request.

## Build & test locally

```bash
dotnet restore
dotnet build --configuration Release
dotnet test
```
