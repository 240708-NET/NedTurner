FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore SimpleSinMachine/
# Build and publish a release
RUN dotnet publish SimpleSinMachine/ -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT [ "dotnet", "AutomaticSinMachine.dll" ]