# Single-stage Dockerfile
# All steps (restore, build, run) happen in one layer — proxy sees every package download

FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app

# Copy project file and restore packages
# Proxy intercepts all NuGet requests here
COPY src/App/App.csproj ./
RUN dotnet restore

# Copy source and build
COPY src/App/ ./
RUN dotnet build -c Release --no-restore

CMD ["dotnet", "run", "--no-build", "-c", "Release"]
