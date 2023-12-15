#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BANKAPI/BANKAPI.csproj", "BANKAPI/"]
RUN dotnet restore "BANKAPI/BANKAPI.csproj"
COPY . .
WORKDIR "/src/BANKAPI"
RUN dotnet build "BANKAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BANKAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BANKAPI.dll"]