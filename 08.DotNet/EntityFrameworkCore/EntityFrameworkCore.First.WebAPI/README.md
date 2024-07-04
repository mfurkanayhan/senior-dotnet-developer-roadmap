# EntityFrameworkCore.First.WebAPI

This project demonstrates basic CRUD (Create, Read, Update, Delete) operations using Entity Framework Core 8.0.6 within a .NET 8.0 ASP.NET Core WebAPI environment. It serves as a practical example of how to integrate Entity Framework Core with ASP.NET Core for effective data management in SQL Server databases.

## Getting Started

This project is part of a larger solution. To set up and run this project, please ensure you follow the general setup instructions available in the main project README which includes environment setup and other prerequisites.

## Features

- Create, read, update, and delete operations through a RESTful API.
- Integration with SQL Server using Entity Framework Core.
- Example of best practices in handling data access in a web application context.

## API Endpoints

This project includes several endpoints to manage `Todo` entities:

- `GET /api/Todos/GetAll`: Retrieves all todos.
- `GET /api/Todos/GetById/{id}`: Retrieves a todo based on its identifier.
- `POST /api/Todos/Add`: Adds a new todo.
- `PUT /api/Todos/Update/{id}`: Updates an existing todo.
- `DELETE /api/Todos/RemoveById/{id}`: Deletes a todo based on its identifier.

## Using the API with Swagger

The project is configured to use Swagger, which provides an interactive UI to test API endpoints directly from your browser. To use Swagger:

1. Run the project from Visual Studio.
2. Navigate to `https://localhost:<port>/swagger` in your web browser. This URL might vary depending on your project's configuration.
3. Use the Swagger UI to send HTTP requests and receive responses from the API.

## Using the API

To interact with the API, you can use tools like Postman or any HTTP client in a web or mobile application. Ensure the server is running by executing the project from your development environment or hosting it on a server.

## Further Information

For more detailed information about the overall solution architecture or other projects within the solution, refer to the main README file located in the root directory of the solution.

For a better understanding of the project, refer to the project files.