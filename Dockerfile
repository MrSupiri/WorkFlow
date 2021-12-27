FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
WORKDIR /src/WorkFlow/Server
RUN dotnet restore "WorkFlow.Server.csproj"
RUN dotnet build "WorkFlow.Server.csproj" -c Release -o /app/build
RUN dotnet publish "WorkFlow.Server.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "WorkFlow.Server.dll"]