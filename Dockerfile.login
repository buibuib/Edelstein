FROM alpine:3.9 as data
WORKDIR /app
RUN apk --update add unzip
ADD https://github.com/Kaioru/Server.Scripts/releases/download/1.0.0-pre1/Data.zip scripts.zip
RUN unzip scripts.zip -d scripts/
ADD https://github.com/Kaioru/Server.NX/releases/download/1.0.0-pre1/Data.zip data.zip
RUN unzip data.zip -d data/

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 as build
WORKDIR /code
COPY . .

RUN dotnet restore
RUN dotnet publish -c Release -o /app src/Edelstein.Service.Login

FROM mcr.microsoft.com/dotnet/core/runtime:3.0 as runtime
WORKDIR /app
COPY --from=data /app .
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Edelstein.Service.Login.dll"]