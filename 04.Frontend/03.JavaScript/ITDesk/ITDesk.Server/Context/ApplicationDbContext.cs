using ITDesk.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ITDesk.Server.Context;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}
