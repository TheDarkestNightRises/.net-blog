FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Blog.WebAPI/Blog.WebAPI.csproj", "Blog.WebAPI/"]
RUN dotnet restore "Blog.WebAPI/Blog.WebAPI.csproj"
COPY . .
WORKDIR "/src/Blog.WebAPI"
RUN dotnet build "Blog.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.WebAPI.dll"]
