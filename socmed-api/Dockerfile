FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["socmed-api.csproj", "."]
RUN dotnet restore "./socmed-api.csproj"

COPY . .
WORKDIR "/src/."
RUN dotnet build "socmed-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "socmed-api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=publish /app/publish .

RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT [ "dotnet", "socmed-api.dll" ]