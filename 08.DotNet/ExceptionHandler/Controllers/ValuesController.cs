using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandler.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
	[HttpGet]
	public IActionResult Get()
	{
        //1
        //try
        //{

        //}
        //catch (Exception)
        //{
        //	//500 200 204 422 429 401
        //	throw;
        //}
        //int x = 0;
        //int y = 0;
        //int z = x / y;

        //throw new ArgumentException("Argument Error");
        //throw new Exception("Exception Error");
        //throw new UnauthorizedAccessException("UnauthorizedAccess Error");
        throw new MyException("My Error");

		return Ok();
	}
}

public class MyException : Exception
{
	public MyException (string message) : base (message)
	{

	}
}