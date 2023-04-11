# Euricom Webshop

This project has been developed as an internal case for the company Euricom NV. The webshop contains both admin as customer functionalities. Admins can view a list of all products available in the webshop, as well as edit, delete, or add new products. Customers can view the products in a grid format and add products to their basket.

## Technology stack
- React: used for the frontend development of the webshop
- .NET7: used for the backend development of the webshop
## Requirements
- Backend
  - Install Visual studio (for Mac or Windows)
    - If you don't want to install Visual studio, you can install the .NET7 SDK found on the following [site](https://dotnet.microsoft.com/en-us/download/dotnet/7.0). This SDK contains also the dotnet cli. This project uses .NET7.
    - When working on a Mac and you don't have the dotnet cli, run the following command: 
```
sudo ln -s /usr/local/share/dotnet/dotnet /usr/local/bin/
```

- Frontend
  - React
  - Pnpm 

## Getting started

To get started with this project, follow the steps below: 
1. Clone the repository to your local machine by running the following command: 
```
    git clone https://github.com/AllisonVandenBergh/InternalCase_Webshop.git
```
2. Navigate to the project directory using the command line.
3. Run the following command: 
```
    dotnet tool install --global dotnet-ef
```
4. Execute the bash script with the name: <b>db_setup.sh</b>

```
    ./db_setup.sh
```

This script will create a MSSQL docker container with the name <b>webshop-database</b> based on the existing MSSQL image.

<b>IMPORTANT!</b>
When working on a Mac with M1 chip, you need to change the image name in the docker compose file or copy the following and paste it in the docker compose file:

```
version: "3.9"
services:
  sql-server:
    container_name: webshop-database
    image: mcr.microsoft.com/azure-sql-edge:latest
    environment:
      ACCEPT_EULA: Y
      SA_PASSWORD: Strong@Passw0rd
    ports:
      - 1433:1433
```

5. Install the necessary dependencies for the frontend. The backend will be automatically restored during the dotnet run which will be executed later.
```
    cd webshop-web
    pnpm install
```
6. Return back to the root directory
```
    cd ..
```
7. Execute the bash script with the name: <b>start.sh</b>
```
    ./start.sh
```
The start script will run the docker container of the MSSQL with name <b>webshop-database</b>. It also opens a iTerm window with 2 tabs, one for the frontend where it will run the command 'pnpm run dev' and one for the backend where it will run the command 'dotnet run watch'.

This script can also be used during development.

8. Navigate to http://localhost:5173/ in your web browser to view the webshop.

In case you get the following error message "ERR_CERT_AUTHORITY_FAILED" when accesing the API, navigate in a new iTerm window to the webshop-api folder and execute the following command: 

```
dotnet dev-certs https --trust
```

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




