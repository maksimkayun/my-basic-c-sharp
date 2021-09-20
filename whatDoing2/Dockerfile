FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["whatDoing2/whatDoing2.csproj", "whatDoing2/"]
RUN dotnet restore "whatDoing2/whatDoing2.csproj"
COPY . .
WORKDIR "/src/whatDoing2"
RUN dotnet build "whatDoing2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "whatDoing2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "whatDoing2.dll"]
