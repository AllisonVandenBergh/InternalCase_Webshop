# Case Study (React / .NET)

## We are going to build a WebShop with

**Quick Intro**

* Admin section (secure)
	* Login with google  account
	* Product List  to add/remove edit products
* Public section (for customer)
	* Product List to showcase all products
	* A way to add a product in the basket
	* Show basket with quantities and total 

**In Details**

* Admin Product Page
	* Table view of all products
	* Sortable columns 
	* Use pagination
	* Server side paging & sorting
	* Can delete and add new product
	* Use fake data to demonstrate large list of products 
		* [https://github.com/bchavez/Bogus)

* Admin Product Form
	* Form to edit/add product
	* Fields: name, description, sku, basePrice, sellPrice, image, stock
	* _(Optional) Upload images to server_ 

* Public Home page
	* Product grid with images, include Title, Desc, Sell Price
	* (optional) infinite scrolling
	* Add buy button to add to basket
	* When products are out of stock, disable buy
	* Add basket to show
		* List of products with quantity and price
		* Total price
		* Remove and edit quantity
		* Basket should be store in DB 

* (Optional)  Authentication with Google Account  & Auth0
	* Secure admin section on webshop
	* Validate token on backend

## Tech Stack:

* General
	* Create a personal GitHub repo an share with coaches
	* Use [Auth0](https://auth0.com/) for auth.
	* _(Optional) Github action to deployment_ 

* Backend 
	* dotNET Code
	* Entity Framework
	* SQL Server or PostgreSQL

* Front-end
	* React SPA
	* Vite & Vitest
	* React-Query for Api access
	* React-Hook-Forms or React-Final-Form  for forms 
	* TailwindCSS for CSS
	* Use DaisyUI or PrimeReact
