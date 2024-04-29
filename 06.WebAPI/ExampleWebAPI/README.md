# ExampleWebAPI - Simple Hello World Endpoint

This minimal ASP.NET Core Web API project defines a single endpoint that responds with a "Hello World!" message. It serves as an introductory example to Web API development with ASP.NET Core.

## Functionality

- The API exposes a POST endpoint at `/api/Furkan`.
- This endpoint accepts a JSON object containing a user's name and a message. It then returns a greeting message that incorporates this data.

### Request Format

POST `/api/Furkan` expects the following JSON object:

```json
{
  "Response": {
    "Message": "Your custom message"
  },
  "Name": "Your Name"
}
```

### Response Format
Upon receiving a valid request, the API responds with:

```json
{
  "Message": "Welcome, Your Name Your custom message"
}
```

### Development and Testing

- To run the project locally, ensure all dependencies are installed, then start the application.
- You can test the endpoint using Swagger UI provided by the application or any HTTP client like Postman or Curl.