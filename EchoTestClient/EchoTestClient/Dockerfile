
FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS echobuild
WORKDIR /EchoTestClient
COPY EchoTestClient/ .

RUN dotnet restore EchoTestClient \
    && dotnet build EchoTestClient --configuration Release --no-restore \
    && dotnet publish EchoTestClient --configuration Release --self-contained=false --runtime linux-x64 --output output

#Run
FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS runtime
WORKDIR /app
COPY --from=echobuild /EchoTestClient/output/ .
ENTRYPOINT ["dotnet", "EchoTestClient.dll"]