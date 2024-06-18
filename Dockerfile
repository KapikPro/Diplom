FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY Diplom/*.sln .
COPY Diplom/Diplom/*.csproj ./Diplom/
COPY Diplom/Diplom/. ./Diplom/
RUN dotnet restore

# copy everything else and build app
WORKDIR /source/Diplom
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Diplom.dll"]