FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY *.sln ./
COPY Api/*.csproj ./Api/
COPY Data/*.csproj ./Data/
COPY Service/*.csproj ./Service/

RUN dotnet restore

COPY Api/. ./Api/
COPY Data/. ./Data/
COPY Service/. ./Service/

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "DockerWebApiTest.dll"]