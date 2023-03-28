FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cijferregistratie/Cijferregistratie.csproj", "Cijferregistratie/"]
RUN dotnet restore "Cijferregistratie/Cijferregistratie.csproj"
COPY . .
WORKDIR "/src/Cijferregistratie"
RUN dotnet build "Cijferregistratie.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cijferregistratie.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cijferregistratie.dll"]
