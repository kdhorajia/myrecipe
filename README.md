# My Recipe

- A simple web app that will allow a user to add new receipe and shop for an ingredients. This is just a simple excercise and design can be optimized further.

### Technology Stack

- .NET Core Web API
- Angular 7
- SQL Server
- Identity Server 4

### Initial Database Design

![Imgur](https://i.imgur.com/3etS134.png)



## DOCKER

### Installing SQL Server 2017 Docker 

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Abcd12345" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2017-latest

### Linking application to SQL Server Docker
docker run -it --rm -p 5000:5000 --link sqlserver -e SQLSERVER_HOST=0.0.0.0:1543 -e SQLSERVER_SA_PASSWORD=Abcd12345 myrecipeapi

### Remove intermediate image used in building

docker image prune
