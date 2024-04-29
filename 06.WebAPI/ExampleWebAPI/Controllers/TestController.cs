using Microsoft.AspNetCore.Mvc;

namespace ExampleWebAPI.Controllers;
[Route("api/Furkan")]
[ApiController]
public class TestController : ControllerBase
{
    // Response response = new();
    private readonly Response _response;

    public TestController(Response response)
    {
        _response = response;
    }

    //GET, PUT, Delete, POST, PATCH, ...

    [HttpPost] // HTTP Metotlar
    public IActionResult Hello(Request request) // endpoint
    {
        _response.Message = $"Welcome, {request.Name}! Your message: {request.Response.Message}";

        return Ok(_response);
    }
}

public class Request
{
    public Response Response { get; set; }
    public string Name { get; set; }
}

public class Response
{
    public string Message { get; set; }
}
