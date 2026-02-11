# tdd-kata

[TDD Kata 1 - String Calculator](https://osherove.com/tdd-kata-1)

## Installed Pre-Reqs

```powershell
    winget install -e --id Microsoft.VisualStudioCode
    winget install -e --id Git.Git

    # dotnet 10 SDK
    powershell -ExecutionPolicy bypass -Command "[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12; & { iwr https://dot.net/v1/dotnet-install.ps1 -OutFile dotnet-install.ps1 }; ./dotnet-install.ps1 -Channel 10.0"

    setx PATH "%PATH%;%UserProfile%\.dotnet\tools"

    dotnet new update
```

## C# Project Creation

```powershell

    dotnet new console -o TddKata.CSharp
```