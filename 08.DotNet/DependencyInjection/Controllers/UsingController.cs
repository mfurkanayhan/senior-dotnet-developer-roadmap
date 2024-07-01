using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsingController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // Process

        // using (Test test = new())
        // {
        //     test.Metot();
        // }

        Test test = new Test();
        test.Metot();
        test.Dispose();

        // using Test test = new();

        // test.Metot();
        
        // process
        // process
        // process
        // process
        // process
        return NoContent();
    }
}

public class Test : IDisposable
{
    public Test()
    {

    }

    public void Dispose()
    {
        // processes
    }

    public void Metot()
    {

    }
}