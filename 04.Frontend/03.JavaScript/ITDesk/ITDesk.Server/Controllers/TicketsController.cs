using ITDesk.Server.Context;
using ITDesk.Server.DTOs;
using ITDesk.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITDesk.Server.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class TicketsController(
    ApplicationDbContext _context) : ControllerBase
{
    [HttpGet("{userId}")]
    public IActionResult GetAll(Guid userId)
    {
        var tickets = _context.Tickets.Where(p => p.UserId == userId).OrderByDescending(p => p.CreatedDate).ToList();

        return Ok(tickets);
    }

    [HttpGet("{id}")]
    public IActionResult GetTicket(Guid id) 
    {
        var ticket = _context.Tickets.FirstOrDefault(p => p.Id == id);
        if (ticket is null) 
        {
            return NotFound();
        }
        return Ok(ticket);
    }

    [HttpPost]
    public IActionResult Create(TicketCreateDto request)
    {
        Ticket ticket = new()
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            UserId = request.UserId,
            Subject = request.Subject,
            IsUrgent = request.IsUrgent,
            Status = "Open"
        };

        _context.Add(ticket);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpPost]
    public IActionResult ChangeStatus(TicketChangeStatusDto request) 
    {
        Ticket? ticket = _context.Tickets.Find(request.Id);
        if (ticket is null)
        {
            throw new ArgumentException("Ticket is not found");
        }

        ticket.Status = request.Status;
        _context.SaveChanges();
        
        return NoContent();
    }

    [HttpPost("{id}")]
    public IActionResult Delete(Guid id) 
    {
        Ticket? ticket = _context.Tickets.Find(id);
        if (ticket is null)
        {
            return NotFound(new { Message = "Ticket not found." });
        }

        _context.Tickets.Remove(ticket);
        _context.SaveChanges();

        return Ok(new { Message = "Ticket successfully deleted." });
    }
}
