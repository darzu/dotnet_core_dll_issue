# Repro:

```
$ dotnet restore
$ dotnet build
$ dotnet build
$ dotnet run --project my_app/my_app.csproj
```

Should fail with:
`Unhandled Exception: System.IO.FileNotFoundException: Could not load file or assembly 'my_lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. The system cannot find the file specified.`

On dotnet --version 1.1.7, but succeed on dotnet --version 2.1.1 (at least)
