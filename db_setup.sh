#!/bin/bash
docker-compose -f docker-compose.yml up -d
dotnet ef database update --project Webshop.Core --startup-project Webshop.Web