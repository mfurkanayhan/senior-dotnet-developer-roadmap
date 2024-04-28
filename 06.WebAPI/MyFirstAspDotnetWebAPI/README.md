# My First Asp Dotnet WebAPI
This project is a simple Web API built using ASP.NET Core. It includes CORS support, Swagger documentation, and basic CRUD operations.

## Getting Started

This section provides steps on how to run the project locally.

### Prerequisites

- .NET 8.0 SDK

### Features

- CORS enabled for all origins, methods, and headers
- Swagger UI for API documentation and interaction
- CRUD operations through RESTful endpoints

### Installation

1. Clone or download the `MyFirstAspDotnetWebAPI` project:
    ```bash
    git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/06.WebAPI/MyFirstAspDotnetWebAPI

    cd 06.WebAPI/MyFirstAspDotnetWebAPI
    ```

2. Run the application:
    ```bash
    dotnet run
    ```

## Usage

Once the application is running, you can access the API documentation and testing interface by visiting `https://localhost:5001/swagger` in your browser.

### API Endpoints

Below are some of the basic endpoints of the API and examples of how to use them:

- **GET `/api/values/queryparams`**

  To retrieve data using query parameters:

  ```http
  GET /api/values/queryparams?id=1&name=John&age=30
  ```

- **GET `/api/values/routingparams/1/John/30`**

  To retrieve data using URL path:
  ```http
  GET /api/values/routingparams/1/John/30
  ```

- **POST `/api/values/notparameterpostrequest`**
  
  For a POST request without parameters:
  ```http
  POST /api/values/notparameterpostrequest
  ```

- **POST `/api/values/postrequest`**

  For a POST request with JSON payload:
  
  ```json
  POST /api/values/postrequest
  {
    "emp1": {
      "name": "John",
      "position": "Developer",
      "department": "IT"
    },
    "emp2": {
      "name": "Jane",
      "position": "Manager",
      "department": "Sales"
    }
  }
  ```

- **PUT `/api/values/update`**
  
  To update an employee:
  ```json
    PUT /api/values/update
  {
    "name": "John Updated",
    "position": "Senior Developer",
    "department": "IT"
  }
  ```

- **DELETE `/api/values/delete`**
  
  To delete an employee:
    
  ```http
  DELETE /api/values/delete?id=1
  ```

## Closing Thoughts
This project aims to provide a starting point for those new to ASP.NET Core Web APIs, offering a foundational understanding of key concepts and operations. May it be the first of many successful projects in your journey as a .NET developer.
