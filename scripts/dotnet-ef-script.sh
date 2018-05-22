#!/bin/bash
cd src/MyStore

# dotnet ef + db update
dotnet ef migrations remove -f
dotnet ef migrations add InitialCreate
dotnet ef database update

cd ../../ 
 