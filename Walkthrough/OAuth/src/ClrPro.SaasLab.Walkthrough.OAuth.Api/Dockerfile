#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ClrPro.SaasLab.Walkthrough.OAuth.Api/ClrPro.SaasLab.Walkthrough.OAuth.Api.csproj", "ClrPro.SaasLab.Walkthrough.OAuth.Api/"]
RUN dotnet restore "ClrPro.SaasLab.Walkthrough.OAuth.Api/ClrPro.SaasLab.Walkthrough.OAuth.Api.csproj"
COPY . .
WORKDIR "/src/ClrPro.SaasLab.Walkthrough.OAuth.Api"
RUN dotnet build "ClrPro.SaasLab.Walkthrough.OAuth.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ClrPro.SaasLab.Walkthrough.OAuth.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClrPro.SaasLab.Walkthrough.OAuth.Api.dll"]