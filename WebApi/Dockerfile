#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WebApi/WebApi.csproj", "WebApi/"]
COPY ["WebApi.LoggerServices/WebApi.LoggerServices.csproj", "WebApi.LoggerServices/"]
COPY ["WebApi.Repository.Contracts/WebApi.Repository.Contracts.csproj", "WebApi.Repository.Contracts/"]
COPY ["WebApi.Models/WebApi.Entities.csproj", "WebApi.Models/"]
COPY ["WebApi.Shared/WebApi.Shared.csproj", "WebApi.Shared/"]
COPY ["WebApi.Service.Contracts/WebApi.Service.Contracts.csproj", "WebApi.Service.Contracts/"]
COPY ["WebApi.Repository/WebApi.Repository.csproj", "WebApi.Repository/"]
COPY ["WebApi.Services/WebApi.Services.csproj", "WebApi.Services/"]
RUN dotnet restore "WebApi/WebApi.csproj"
COPY . .
WORKDIR "/src/WebApi"
RUN dotnet build "WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.dll"]