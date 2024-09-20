#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Otomotiv.Api.Web/Otomotiv.Api.Web.csproj", "Otomotiv.Api.Web/"]
COPY ["Otomotive.Api.Services/Otomotiv.Application.csproj", "Otomotive.Api.Services/"]
COPY ["brands/Otomotiv.Api.Audi/Otomotiv.Api.Brands.Audi.csproj", "brands/Otomotiv.Api.Audi/"]
COPY ["shared/Otomotiv.Api.Common/Otomotiv.Api.Common.csproj", "shared/Otomotiv.Api.Common/"]
COPY ["brands/Otomotiv.Api.Brands.Base/Otomotiv.Api.Brands.Base.csproj", "brands/Otomotiv.Api.Brands.Base/"]
COPY ["brands/Otomotiv.Api.VolksWagen/Otomotiv.Api.Brands.VolksWagen.csproj", "brands/Otomotiv.Api.VolksWagen/"]
COPY ["Otomotiv.Infrastructure/Otomotiv.Infrastructure.csproj", "Otomotiv.Infrastructure/"]
RUN dotnet restore "./Otomotiv.Api.Web/Otomotiv.Api.Web.csproj"
COPY . .
WORKDIR "/src/Otomotiv.Api.Web"
RUN dotnet build "./Otomotiv.Api.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Otomotiv.Api.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Otomotiv.Api.Web.dll"]