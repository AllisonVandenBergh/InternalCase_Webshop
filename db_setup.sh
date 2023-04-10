#!/bin/bash
docker-compose -f docker-compose.yml up -d
dotnet ef database update --project webshop-api/Infrastructure --startup-project webshop-api/Api