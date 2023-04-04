#!/bin/bash

read -p "Enter the name of the migration you want to create: " migrationName
echo "Creating '$migrationName' migration."

dotnet ef migrations add $migrationName --project Infrastructure --startup-project Api --output-dir Migrations
dotnet ef database update --project Infrastructure --startup-project Api