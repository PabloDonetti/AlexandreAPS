FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/MinhaAplicacao.Api/MinhaAplicacao.Api.csproj", "MinhaAplicacao.Api/"]
COPY ["src/MinhaAplicacao.Application/MinhaAplicacao.Application.csproj", "MinhaAplicacao.Application/"]
COPY ["src/MinhaAplicacao.Domain/MinhaAplicacao.Domain.csproj", "MinhaAplicacao.Domain/"]
COPY ["src/MinhaAplicacao.Infrastructure/MinhaAplicacao.Infrastructure.csproj", "MinhaAplicacao.Infrastructure/"]
RUN dotnet restore "MinhaAplicacao.Api/MinhaAplicacao.Api.csproj"
COPY . .
WORKDIR "/src/MinhaAplicacao.Api"
RUN dotnet build "MinhaAplicacao.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MinhaAplicacao.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinhaAplicacao.Api.dll"]