#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ReliabilityOptimizationCalc.Server/ReliabilityOptimizationCalc.Server.csproj", "ReliabilityOptimizationCalc.Server/"]
RUN dotnet restore "./ReliabilityOptimizationCalc.Server/ReliabilityOptimizationCalc.Server.csproj"
COPY . .
WORKDIR "/src/ReliabilityOptimizationCalc.Server"
RUN dotnet build "./ReliabilityOptimizationCalc.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ReliabilityOptimizationCalc.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReliabilityOptimizationCalc.Server.dll"]