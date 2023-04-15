#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
WORKDIR "/src/Alumnisystem.App/Server"

FROM build AS publish

FROM base AS final
WORKDIR /app
ENTRYPOINT ["dotnet", "Alumnisystem.App.Server.dll"]