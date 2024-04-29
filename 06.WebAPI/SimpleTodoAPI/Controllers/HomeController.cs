using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleTodoAPI.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class HomeController : ControllerBase
{
    public static List<string> Todos = new() { "Furkan Ayhan" };
    [HttpGet]

    public IActionResult Get()
    {
        // Todos.Add("name");
        return Ok(Todos);
    }

    [HttpPost]
    public IActionResult Add(User user)
    {
        Todos.Add(user.Name + " " + user.LastName);
        return Ok(Todos);
    }

    /*
    [HttpGet]
    public IActionResult Get()
    {
        // A example = new(); // instance created
        // example.Id = 5;

        return Ok(new
        {
            Message = "API request was successfully executed!",
            Count = A.Id
        }) ;
    }

    [HttpGet]
    public IActionResult Test()
    {
        return NoContent();
    }
    */
}

public class User
{
    public string Name { get; set; }
    public string LastName { get; set; }
}

/*
public class A
{
    public static int Id { get; set; } = 5;
}
*/
