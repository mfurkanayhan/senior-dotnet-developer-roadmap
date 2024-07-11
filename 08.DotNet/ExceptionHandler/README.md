# ExceptionHandler Project

**Description:**  
The ExceptionHandler project is designed to demonstrate the handling of exceptions within an ASP.NET Core application. This simple project utilizes custom middleware to intercept and process exceptions, returning appropriate HTTP status codes and messages to the client.

**Features:**
1. **Custom Exceptions:** Implements a custom exception (`MyException`) to showcase handling specific types of errors.
2. **Middleware Components:**
   - `ExceptionMiddleware`: Catches any unhandled exceptions during the request pipeline and returns a JSON response with the error message.
   - `Net8ExceptionMiddleware`: A specific implementation that maps different types of exceptions to corresponding HTTP status codes.
3. **Extension Method:** Uses an extension method (`UseException`) to easily integrate the exception handling middleware into the application pipeline.

**Setup and Running:**
- Clone the repository and open the project in Visual Studio.
- Build the solution to restore the necessary packages.
- Run the project which will open Swagger UI in development mode, allowing you to test API endpoints.

**API Endpoints:**
- `GET /api/values`: This endpoint throws a custom `MyException` which is caught by the configured middleware and responds with a 301 status code and a custom error message.

**Exception Handling:**
- Exceptions are processed using two middleware components that intercept exceptions and format them into a consistent JSON response. The `ExceptionMiddleware` handles generic exceptions, while `Net8ExceptionMiddleware` deals with specific exceptions like `ArgumentException`, `UnauthorizedAccessException`, and custom `MyException`.

**Note:** This project is a basic example meant for educational purposes on handling exceptions in ASP.NET Core applications.

---