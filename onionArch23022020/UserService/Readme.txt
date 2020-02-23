https://social.technet.microsoft.com/wiki/contents/articles/36655.onion-architecture-in-asp-net-core-mvc.aspx

Benifits of onion arch
1> seperation of concern
2> loosly coupled.

* write dbset in generic class seperately

connection
Data Source=DESKTOP-DNQ619S;Initial Catalog=test;Integrated Security=True

  "ConnectionStrings": {
    "DefaultConnection": "Data Source=DESKTOP-DNQ619S;Initial Catalog=OnionArchDb;Integrated Security=True"
  }


dotnet tool install --global dotnet-ef
dotnet add package microsoft.entityframeworkcore
dotnet add package microsoft.entityframeworkcore.design
dotnet add package microsoft.entityframeworkcore.sqlserver

dotnet --version : to check version

structurre:
model: 
repository
json
startup
Data
Validation folder: used to validate db structure.
endpoint > will expose reposiitory fun to endpoint

-- migration -- in migration script is created
dotnet ef migrations add initial
dotnet ef database update

dotnet build
dotnet run

----
iis deploy

1: create extension folder in root
2: create file MyExtension.cs

some file added..
compile dotnet build
dotnet publish
