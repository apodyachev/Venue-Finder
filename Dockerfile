FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Venue Finder/Venue Finder.csproj", "Venue Finder/"]
RUN dotnet restore "Venue Finder/Venue Finder.csproj"
COPY . .
WORKDIR "/src/Venue Finder"
RUN dotnet build "Venue Finder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Venue Finder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Venue Finder.dll"]