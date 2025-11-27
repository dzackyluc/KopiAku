FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["BRIEFF8.csproj", "./"]
RUN dotnet restore "BRIEFF8.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "BRIEFF8.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BRIEFF8.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BRIEFF8.dll"]