FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build
WORKDIR /app

COPY src/clients/client ./
RUN dotnet restore
RUN dotnet publish -o /app/out -c Release

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /app
EXPOSE 80

COPY --from=build /app/out /app
ENTRYPOINT [ "dotnet", "/app/Client.dll" ]