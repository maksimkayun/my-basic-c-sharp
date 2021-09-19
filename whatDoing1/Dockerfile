FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["whatDoing1/whatDoing1.csproj", "whatDoing1/"]
RUN dotnet restore "whatDoing1/whatDoing1.csproj"
COPY . .
WORKDIR "/src/whatDoing1"
RUN dotnet build "whatDoing1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "whatDoing1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "whatDoing1.dll"]
