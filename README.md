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
3. Install the necessary dependencies for the frontend and backend by running the following commands:
```
    cd webshop-web
    pnpm install

    cd ../webshop-api
    dotnet restore
```
4. Run the dockerfile for setting a local database up for the project
5. Run the backend by running the following command: 
```
    cd webshop-api
    dotnet run
```
6. Run the frontend by running the following command:
```
    cd webshop-web
    pnpm dev
```
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




