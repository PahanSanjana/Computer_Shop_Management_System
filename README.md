# Computer Shop Management System

## Overview

The Computer Shop Management System is a Windows Forms Application built with the .NET Framework using C# and backed by Microsoft SQL Server Management Studio as the database. This system helps manage inventory, generate bills, and track product availability efficiently.

## Features

-   **Product Management:** Add, update, and delete products with model numbers and quantities.
-   **Billing System:** Generate bills based on model number and requested quantity.
-   **Inventory Tracking:** Maintain a live record of available stock.
-   **User-Friendly Interface:** Simple and intuitive design for easy navigation.

## Tools & Technologies

-   **Frontend:** Windows Forms (.NET Framework)
-   **Backend:** C#
-   **Database:** Microsoft SQL Server Management Studio
-   **IDE:** Visual Studio

## Installation & Setup

1.  **Clone the Repository:**

    ```bash
    git clone [https://github.com/PahanSanjana/Computer_Shop_Management_System.git](https://www.google.com/search?q=https://github.com/PahanSanjana/Computer_Shop_Management_System.git)
    ```

2.  **Open the Project:**

    -   Launch Visual Studio and open the solution file (`.sln`).

3.  **Database Configuration:**

    -   Create a new database in SQL Server Management Studio.
    -   Execute the provided SQL scripts to set up tables (Products, Sales, etc.).
    -   Update the connection string in `App.config`:

        ```xml
        <connectionStrings>
          <add name="DBConnection" connectionString="Data Source=SERVER_NAME;Initial Catalog=DB_NAME;Integrated Security=True" providerName="System.Data.SqlClient"/>
        </connectionStrings>
        ```

        Replace `SERVER_NAME` and `DB_NAME` with your SQL Server instance and database name.

4.  **Build and Run:**

    -   Build the solution (Ctrl + Shift + B).
    -   Run the application (F5).

## Database Schema

-   **Products:** `ProductID`, `ModelNumber`, `ProductName`, `Quantity`, `Price`
-   **Sales:** `SaleID`, `ProductID`, `QuantitySold`, `TotalPrice`, `SaleDate`

## Usage

-   **Add Products:** Enter product details (model number, name, quantity, price) to add items to inventory.
-   **Generate Bill:** Input the model number and quantity to generate a detailed bill.
-   **View Inventory:** Check current stock availability and update product details as needed.

## Future Enhancements

-   **User Authentication:** Secure access for different user roles (admin, cashier, etc.).
-   **Reporting:** Generate sales and inventory reports.
-   **Product Search:** Search by model number or name for quick access.

## License

This project is open-source and free to use.

## Contact

For any queries or contributions, feel free to reach out via [pahansanjana6226@gmail.com].
