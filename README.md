# Euricom Webshop

This project has been developed as an internal case for the company Euricom NV. The webshop contains both admin as customer functionalities. Admins can view a list of all products available in the webshop, as well as edit, delete, or add new products. Customers can view the products in a grid format and add products to their basket.

## Technology stack
- React: used for the frontend development of the webshop
- .NET7: used for the backend development of the webshop
## Getting started
To get started with this project, follow the steps below: 
1. Clone the repository to your local machine by running the following command: 
```
    git clone https://github.com/AllisonVandenBergh/InternalCase_Webshop.git
```
2. Navigate to the project directory using the command line.
3. Execute the bash script with the name: <b>db_setup.sh</b>

```
    ./db_setup.sh
```

This script will create a MSSQL docker container with the name <b>webshop-database</b> based on the existing MSSQL image.


4. Install the necessary dependencies for the frontend. The backend will be automatically restored during the dotnet run which will be executed later.
```
    cd webshop-web
    pnpm install
```
5. Return back to the root directory
```
    cd ..
```
6. Execute the bash script with the name: <b>start.sh</b>
```
    ./start.sh
```
The start script will run the docker container of the MSSQL with name <b>webshop-database</b>. It also opens a iTerm window with 2 tabs, one for the frontend where it will run the command 'pnpm run dev' and one for the backend where it will run the command 'dotnet run watch'.

This script can also be used during development.

7. Navigate to http://localhost:5173/ in your web browser to view the webshop.

## Usage
### Admin
As an admin, you can do the following:

- View a list of all products available in the webshop.
- Edit a product by clicking on the pencil button next to the product.
- Delete a product by clicking on the trashcan button next to the product.
- Add a new product by clicking on the "+ Add new product" button.

### Customer
As a customer, you can do the following:

- View a list of all products available in the webshop.
- Add a product to your basket by clicking on the "Add to Basket" button next to the product.




