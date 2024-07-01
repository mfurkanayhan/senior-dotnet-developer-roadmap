# DependencyInjection Project

## Overview

This project demonstrates the use of dependency injection in a .NET application. It includes examples of adding, updating, and deleting products in both MSSQL and NoSQL databases.

## Controllers

### ProductsController.cs

Handles operations related to products using dependency injection with the `IProductRepository` interface.

- **Add**: Adds a product.
- **Update**: Updates a product.
- **Delete**: Deletes a product.

### UsingController.cs

Demonstrates the use of `IDisposable` and basic process handling.

### ValuesController.cs

Uses the `Calculator` service and class `A` to perform basic arithmetic operations through dependency injection.

## Repositories

### IProductRepository.cs

Defines the interface for product repository operations.

- **Add**: Adds a product.
- **Update**: Updates a product.
- **Delete**: Deletes a product.

### ProductRepository.cs

Implements `IProductRepository` for MSSQL database operations.

- **Add**: Adding a product to MSSQL Database.
- **Update**: Updating a product in MSSQL Database.
- **Delete**: Deleting a product from MSSQL Database.

### ProductRepositoryNew.cs

Implements `IProductRepository` for NoSQL database operations.

- **Add**: NoSQL Add Operation.
- **Update**: NoSQL Update Operation.
- **Delete**: NoSQL Delete Operation.

## Services

### Calculator.cs

Provides basic arithmetic operations and demonstrates the use of access modifiers in C#.

## Program.cs

Sets up the dependency injection container and configures services and middleware for the application.

- **Dependency Injection**: Configures services for dependency injection.
- **Swagger**: Configures Swagger for API documentation in development mode.
- **Controllers**: Maps controllers for handling HTTP requests.

---

### How to Run

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore the NuGet packages.
4. Run the application.

### Contributing

Feel free to contribute to this project by creating issues or submitting pull requests.
