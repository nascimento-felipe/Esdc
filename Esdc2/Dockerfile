FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Esdc2/Esdc2.csproj", "Esdc2/"]
RUN dotnet restore "Esdc2/Esdc2.csproj"
COPY . .
WORKDIR "/src/Esdc2"
RUN dotnet build "Esdc2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Esdc2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Esdc2.dll"]
