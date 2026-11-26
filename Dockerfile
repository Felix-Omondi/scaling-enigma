FROM mcr.microsoft.com/dotnet/sdk:11.0-alpine
WORKDIR /src
COPY . /src/
RUN dotnet publish "scaling-enigma.csproj" -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:11.0-alpine
WORKDIR /app
COPY --from=build /publish /app/

ENTRYPOINT [ "dotnet", "scaling-enigma.dll" ]