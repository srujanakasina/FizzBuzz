FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app
EXPOSE 80
EXPOSE 8080

COPY ./src/FizzBuzz/FizzBuzz.csproj ./FizzBuzz/

RUN dotnet restore ./FizzBuzz/FizzBuzz.csproj

COPY ./src/ ./
WORKDIR /app/FizzBuzz/
RUN dotnet publish FizzBuzz.csproj -c Release -o /dist

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /dist ./

ENTRYPOINT ["dotnet", "FizzBuzz.dll"]