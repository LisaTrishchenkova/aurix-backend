# См. статью по ссылке https://aka.ms/customizecontainer, чтобы узнать как настроить контейнер отладки и как Visual Studio использует этот Dockerfile для создания образов для ускорения отладки.

# Этот этап используется при запуске из VS в быстром режиме (по умолчанию для конфигурации отладки)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Добавляем отладчик VS
RUN apt-get update && \
    apt-get install -y curl unzip && \
    curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /vsdbg


FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
# Меняем на Debug для отладки!
ARG BUILD_CONFIGURATION=Debug  # ← ИЗМЕНИЛИ ЗДЕСЬ
WORKDIR /src
COPY ["Aurix/Aurix.csproj", "Aurix/"]
RUN dotnet restore "./Aurix/Aurix.csproj"
COPY . .
WORKDIR "/src/Aurix"
RUN dotnet build "./Aurix.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Debug  # ← И ЗДЕСЬ
RUN dotnet publish "./Aurix.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Aurix.dll"]
