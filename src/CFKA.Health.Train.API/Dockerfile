#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

# HTTP/1 - Restful API
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CFKA.Health.Train.API/CFKA.Health.Train.API.csproj", "CFKA.Health.Train.API/"]
COPY ["CFKA.Health.Train.Application/CFKA.Health.Train.Application.csproj", "CFKA.Health.Train.Application/"]
COPY ["CFKA.Health.Train.Domain/CFKA.Health.Train.Domain.csproj", "CFKA.Health.Train.Domain/"]
COPY ["CFKA.Health.Train.Infrasctructure/CFKA.Health.Train.Infrastructure.csproj", "CFKA.Health.Train.Infrasctructure/"]
RUN dotnet restore "CFKA.Health.Train.API/CFKA.Health.Train.API.csproj"
COPY . .
WORKDIR "/src/CFKA.Health.Train.API"
RUN dotnet build "CFKA.Health.Train.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CFKA.Health.Train.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CFKA.Health.Train.API.dll"]