using EntityFrameworkCore.First.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.First.WebAPI.Context;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=EFCoreFirstWebAPI;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }

    public DbSet<Todo> Todos { get; set; }
}
