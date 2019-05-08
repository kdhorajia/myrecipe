FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MyRecipe.Api/MyRecipe.Api.csproj", "MyRecipe.Api/"]
COPY ["MyRecipe.Data/MyRecipe.Data.csproj", "MyRecipe.Data/"]
COPY ["MyRecipe.Models/MyRecipe.Models.csproj", "MyRecipe.Models/"]
COPY ["MyRecipe.Common/MyRecipe.Common.csproj", "MyRecipe.Common/"]
COPY ["MyRecipe.Core/MyRecipe.Core.csproj", "MyRecipe.Core/"]
RUN dotnet restore "MyRecipe.Api/MyRecipe.Api.csproj"
COPY . .
WORKDIR "/src/MyRecipe.Api"
RUN dotnet build "MyRecipe.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyRecipe.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyRecipe.Api.dll"]