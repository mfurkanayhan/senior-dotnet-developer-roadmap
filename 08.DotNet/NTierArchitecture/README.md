# NTierArchitecture

The `NTierArchitecture` project is a .NET Core application that provides a multi-layered (N-Tier) architecture for modern web APIs. This project has been crafted using Entity Framework Core, ASP.NET Core, and a variety of design patterns.

## Project Structure

The project is divided into the following main layers:

- **NTierArchitecture.Entities**: Contains the database models and DTOs.
- **NTierArchitecture.DataAccess**: Contains the database context and repositories.
- **NTierArchitecture.Business**: Contains the business rules and service layer.
- **NTierArchitecture.WebAPI**: Manages HTTP requests and serves RESTful API endpoints.

Each layer is designed in accordance with SOLID principles, and inter-layer dependencies are minimized.

### Installation

1. Clone or download the project from GitHub:
    ```sh
    git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap.git
    ```

2. Navigate to the `NTierArchitecture.WebAPI` directory:
    ```sh
    cd .\08.DotNet\NTierArchitecture\NTierArchitecture.WebAPI
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

You can test the API via Swagger UI by going to `http://localhost:7203/swagger` in your browser.

## Homework

1. **Include Identity Library:** Incorporate the ASP.NET Core Identity library into the project to set up a user management structure.
2. **Create and Connect User Class to Identity:** Create a custom `User` class and integrate it with ASP.NET Core Identity.
3. **Associate DbContext with Identity Library:** Update your `ApplicationDbContext` class to integrate with Identity.
4. **User Creation in Middleware:** If there are no users in the system, use middleware in `Program.cs` to automatically create a new user.
5. **Write a Login Method:** Write a login method that allows users to log into the system.
6. **Set Up JWT Structure:** Return a JWT token after login.
7. **Implement Authentication Control:** Use the `[Authorize]` attribute to ensure that only authorized users can access certain endpoints.

For detailed information and testing capabilities for each endpoint, run the project and use the Swagger UI interface.

For a better understanding of the project, refer to the project files.