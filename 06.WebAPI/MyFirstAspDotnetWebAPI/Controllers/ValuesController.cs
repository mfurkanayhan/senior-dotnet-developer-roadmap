using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAspDotnetWebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet("[action]")]
    public IActionResult QueryParams(int id, string name, int age)
    {
        var request = HttpContext.Request;
        return Ok(new { Message = "API is working!" });
    }

    [HttpGet("[action]/{id}/{name}/{age}")]
    public IActionResult RoutingParams(int id, string name, int age)
    {
        var request = HttpContext.Request;
        return Ok(new { Message = "API is working!" });
    }

    [HttpPost("[action]")]
    public IActionResult NotParameterPostRequest()
    {
        return Ok(new { Message = "No parameters!" });
    }

    [HttpPost("[action]")]
    public IActionResult PostRequest(EmployeeRequestDto request)
    {
        return Ok(new { Message = "Employee added successfully : {employee.Name}" });
    }

    [HttpPut("Update")]
    public IActionResult Update(Employee employee)
    {
        return Ok(new { Message = "I will update!" });
    }

    [HttpDelete("[action]")]
    public IActionResult Delete(int id)
    {
        Employee employee = new()
        {
            Name = "",
            Department = "",
            Position = ""
        };

        return Ok(new { Message = "I will delete!" });
    }
}

public class EmployeeRequestDto
{
    public Employee Emp1 { get; set; }
    public Employee Emp2 { get; set; }
}

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
}
