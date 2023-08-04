FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CineClubeApp/CineClubeApp.csproj", "CineClubeApp/" ]
RUN dotnet restore "CineClubeApp/CineClubeApp.csproj"

WORKDIR "/src/CineClubeApp"
COPY CineClubeApp/. .
RUN dotnet build "CineClubeApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CineClubeApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "CineClubeApp.dll" ]