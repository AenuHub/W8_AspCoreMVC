## W8_AspCoreMVC - ASP.NET Core MVC Project: Customer and Orders Management

This project demonstrates the use of **MVC design pattern** in an ASP.NET Core application. The goal is to build a 
simple system to manage customers and their orders using **Models**, **ViewModels**, **Controllers**, and **Views**.

### Task 1: Model Creation
1. **Customer Model**
    - Create a `Customer` class with the following properties:
        - `Id` (Unique identifier for the customer, `int`)
        - `FirstName` (Customer's first name, `string`)
        - `LastName` (Customer's last name, `string`)
        - `Email` (Customer's email address, `string`)

2. **Order Model**
    - Create an `Order` class with the following properties:
        - `Id` (Unique identifier for the order, `int`)
        - `ProductName` (Name of the product, `string`)
        - `Price` (Price of the product, `decimal`)
        - `Quantity` (Quantity of the product ordered, `int`)

---

### Task 2: ViewModel Creation
1. **CustomerOrderViewModel**
    - Create a `CustomerOrderViewModel` class with the following properties:
        - `Customer` (A `Customer` object)
        - `Orders` (A list of `Order` objects)

    - The ViewModel combines model data and additional information needed for the view.

---

### Task 3: Controller Creation
1. **CustomerOrdersController**
    - Create a `CustomerOrdersController` class.
    - Inside the controller, add an `Index` action method:
        - Instantiate a sample `Customer` object.
        - Instantiate a few sample `Order` objects.
        - Use these objects to create a `CustomerOrderViewModel` instance.
        - Pass the `CustomerOrderViewModel` instance to the view.

---

### Task 4: View Creation
1. **Index View**
    - Create a `Views/CustomerOrders` folder.
    - Add a `Index.cshtml` view file inside the folder.

    - **View Requirements**:
        - Display customer details (ID, first name, last name, email).
        - Show a table listing the orders with columns for:
            - Order ID
            - Product Name
            - Price
            - Quantity