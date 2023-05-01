FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["InnovaMind.API/InnovaMind.API.csproj", "InnovaMind.API/"]
RUN dotnet restore "InnovaMind.API/InnovaMind.API.csproj"
COPY . .
WORKDIR "/src/InnovaMind.API"
RUN dotnet build "InnovaMind.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InnovaMind.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InnovaMind.API.dll"]
