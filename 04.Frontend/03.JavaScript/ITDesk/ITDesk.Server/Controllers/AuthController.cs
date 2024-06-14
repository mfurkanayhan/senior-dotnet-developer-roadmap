using ITDesk.Server.DTOs;
using ITDesk.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITDesk.Server.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    public IActionResult Register(RegisterDto request)
    {
        _authService.Register(request);

        return NoContent();
    }

    [HttpPost]
    public IActionResult Login(LoginDto request) 
    {
        var response = _authService.Login(request);
        return Ok(response);
    }
}
