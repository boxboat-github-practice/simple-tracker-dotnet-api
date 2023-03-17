FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/SimpleTracker.Api/SimpleTracker.Api.csproj", "src/SimpleTracker.Api/"]
RUN dotnet restore "src/SimpleTracker.Api/SimpleTracker.Api.csproj"
COPY . .
WORKDIR "/src/src/SimpleTracker.Api"
RUN dotnet build "SimpleTracker.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleTracker.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleTracker.Api.dll"]
