FROM mcr.microsoft.com/dotnet/sdk:11.0
WORKDIR /src
COPY . /src/
RUN dotnet publish "scaling-enigma.csproj" -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:11.0
WORKDIR /app
COPY --from=build /publish /app/

EXPOSE 8080

ENTRYPOINT [ "dotnet", "scaling-enigma.dll" ]