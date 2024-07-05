# ClassStructuresApp

ClassStructuresApp is a .NET Web API for managing product inventories. This application allows users to add products, manage stock levels, process sales, and generate reports on product stock levels.

## Getting Started

These instructions will get your copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022
- This project uses the integrated Swagger UI in Visual Studio for testing the API endpoints, eliminating the need for external tools like Postman or any other API testing tool.

### Installation

1. Clone or download the project from GitHub:
    ```sh
    git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap.git
    ```

2. Navigate to the `ClassStructuresApp.WebAPI` directory:
    ```sh
    cd .\08.DotNet\ClassStructuresApp\ClassStructuresApp.WebAPI
    ```

3. Restore dependencies and build the project:
    ```sh
    dotnet restore
    dotnet build
    ```

### Running

To run the project:

```sh
dotnet run
```

You can test the API via Swagger UI by going to `http://localhost:7105/swagger` in your browser.

### Usage
Below are a few examples of how you can use the API endpoints:

#### Add a Product
```http
POST /api/Values/Add
Content-Type: application/json

{
  "Name": "New Product",
  "Quantity": 100,
  "Price": 19.99
}
```

#### Get All Products
```http
GET /api/Values/GetAll
```

#### Sell a Product
```http
GET /api/Values/Selling?productId={productId}&quantity={quantity}
```

#### Add Stock to a Product
```http
GET /api/Values/AddStock?productId={productId}&quantity={quantity}
```

#### Generate Product Report
```http
GET /api/Values/GetProductForReport
```

For detailed information and testing capabilities for each endpoint, run the project and use the Swagger UI interface.

For a better understanding of the project, refer to the project files.