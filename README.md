# Euricom Webshop

This project has been developed as an internal case for the company Euricom NV. The webshop contains both admin as customer functionalities. Admins can view a list of all products available in the webshop, as well as edit, delete, or add new products. Customers can view the products in a grid format and add products to their basket.

## Technology stack
- React: used for the frontend development of the webshop
- .NET7: used for the backend development of the webshop

## Prerequisites
- Backend
  - Install docker
    - Also possible to install docker desktop
  - Install dotnet
    - Install Visual studio (for Mac or Windows)
    - In case when you don't want to install Visual studio, install the .NET7 SDK found on the following [site](https://dotnet.microsoft.com/en-us/download/dotnet/7.0). This SDK contains also the dotnet cli.
- Frontend
  - Install node
  - Install pnpm

## Quick Start

### With the commandline

```bash
# Run SQL Server in docker
docker-compose -f docker-compose.yml up -d

# Run SQL Server in docker - Mac M1 users
docker-compose -f docker-compose-arm.yml up -d

# Install dotnet-ef
dotnet tool install --global dotnet-ef

# Run DB update
dotnet ef database update --project Webshop.Core --startup-project Webshop.Web

# Seed the DB with Bogus data
dotnet run --project Webshop.DbSeed

# Start DB
docker start webshop-database

# Install dependencies frontend
cd ./webshop-web
pnpm install

# Start API (BE)
dotnet run watch --project ${current_folder}/webshop-api/Api --launch-profile https

# Start React SPA
cd ./webshop-web 
pnpm run dev
```

### With NPM
This project contains npm scripts that can be used.
```bash
# Run SQL Server in docker
npm run db:up

# Run SQL Server in docker - Mac M1 users
npm run db:upMac

# Run DB update
npm run db:update

# Seed the DB with Bogus data
npm run db:seed

# Start DB
npm run db:start

# Install dependencies frontend
npm run web:install

# Start API (BE)
npm run start:api

# Start React SPA
npm run start:web
```
## Url
- Default the frontend project wil run on: http://localhost:5173
  - Port can change based on your configuration.
- Backend project wil run on: https://localhost:7236/
  - Port can change based on your configuration.
  - The url in the frontend can be found in the environment file (.env)
- Swagger UI runs on: https://localhost:7230/swagger/index.html
- The production URL: ...

## Usage
### Admin
As an admin, you can do the following:

- View a list of all products available in the webshop.
- Sort, use pagination on the table.
- Edit a product by clicking on the pencil button next to the product.
- Delete a product by clicking on the trashcan button next to the product.
- Add a new product by clicking on the "+ Add new product" button.

### Customer
As a customer, you can do the following:

- View a list of all products available in the webshop.
- Add a product to your basket by clicking on the "Add to Basket" button next to the product.

## Issues solved 
In case you get the following error message "ERR_CERT_AUTHORITY_FAILED" when accesing the API, navigate in a new terminal window to the webshop-api folder and execute the following command: 

```
dotnet dev-certs https --trust
```

## Issues solved for Mac M1 chip users
- After downloading the .NET7 SDK (standalone or with visual studio), and you don't have the dotnet CLI, run the following command:
```
sudo ln -s /usr/local/share/dotnet/dotnet /usr/local/bin/
```
<b>IMPORTANT!</b> The path of where dotnet is installed may vary!

- The script for running the database setup will not work because the docker compose file contains the wrong image name for Mac M1 users. More information about this issue can be found on the following [site](https://github.com/microsoft/mssql-docker/issues/668). Use the docker compose file with name: docker-compose-arm.yml.


