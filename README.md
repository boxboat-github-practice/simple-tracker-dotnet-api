# SimpleTracker.Api - ASP.NET Core 3.1 Server

This API allows management of client contracts and tracks history of employee contract assignments


## Upgrade NuGet Packages

NuGet packages get frequently updated.

To upgrade this solution to the latest version of all NuGet packages, use the dotnet-outdated tool.


Install dotnet-outdated tool:

```
dotnet tool install --global dotnet-outdated-tool
```

Upgrade only to new minor versions of packages

```
dotnet outdated --upgrade --version-lock Major
```

Upgrade to all new versions of packages (more likely to include breaking API changes)

```
dotnet outdated --upgrade
```


## Build

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run

```
dotnet run -p src/SimpleTracker.Api/SimpleTracker.Api.csproj
```

## Run in Docker

```
cd src/SimpleTracker.Api
docker build -t simpletracker.api .
docker run -p 5000:8080 simpletracker.api
```
