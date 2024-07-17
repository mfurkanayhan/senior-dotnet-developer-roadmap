# CancellationToken Web API

This project is an example of an ASP.NET Core Web API application that uses `CancellationToken` to cancel asynchronous operations. It also uses a custom NuGet package [`DefaultAllowCorsPolicy`](https://www.nuget.org/packages/DefaultAllowCorsPolicy) created by the user to add a default CORS (Cross-Origin Resource Sharing) policy.

## Features

- **Asynchronous Operation Cancellation**: Allows cancellation of long-running tasks using `CancellationToken`.
- **Default CORS Policy**: Accepts requests from all origins, methods, and headers.
- **Swagger UI Integration**: Provides API documentation and testing through Swagger UI.

## Setup and Run

1. Restore the NuGet packages:
    ```bash
    dotnet restore
    ```

2. Start the application:
    ```bash
    dotnet run
    ```

3. Access and test the API endpoints:
    - `GET /api/values`: Returns a list of names after a 5-second delay, which can be cancelled.

## Technologies Used

- ASP.NET Core
- Custom NuGet package [`DefaultAllowCorsPolicy`](https://www.nuget.org/packages/DefaultAllowCorsPolicy)
- Swagger/OpenAPI

## Sample Request

```bash
curl -X GET "https://localhost:5001/api/values"
