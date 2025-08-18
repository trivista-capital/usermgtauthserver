#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Trivister.IDP/Trivister.IDP.csproj", "Trivister.IDP/"]
COPY ["Trivister.ApplicationServices/Trivister.ApplicationServices.csproj", "Trivister.ApplicationServices/"]
COPY ["Trivister.Common/Trivister.Common.csproj", "Trivister.Common/"]
COPY ["Trivister.Core/Trivister.Core.csproj", "Trivister.Core/"]
COPY ["Trivister.DataStore/Trivister.DataStore.csproj", "Trivister.DataStore/"]
COPY ["Trivister.Infrastructure/Trivister.Infrastructure.csproj", "Trivister.Infrastructure/"]
RUN dotnet restore "./Trivister.IDP/./Trivister.IDP.csproj"
COPY . .
WORKDIR "/src/Trivister.IDP"
RUN dotnet build "./Trivister.IDP.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Trivister.IDP.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Trivister.IDP.dll"]