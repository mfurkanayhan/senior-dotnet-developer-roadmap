using Microsoft.EntityFrameworkCore;
using QickServer.Domain.Users;

namespace QickServer.Infrastructure.Context;
internal sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {}

    public DbSet<User> Users { get; set; }
}
