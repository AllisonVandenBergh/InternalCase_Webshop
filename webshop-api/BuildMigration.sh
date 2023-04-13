#!/bin/bash

read -p "Enter the name of the migration you want to create: " migrationName
echo "Creating '$migrationName' migration."

dotnet ef migrations add $migrationName --project Webshop.Core --startup-project Webshop.Web --output-dir Infrastructure/Migrations
dotnet ef database update --project Webshop.Core --startup-project Webshop.Web