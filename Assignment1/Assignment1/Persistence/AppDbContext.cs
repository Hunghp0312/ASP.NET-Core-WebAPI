using Microsoft.EntityFrameworkCore;
using Domain;
namespace Assignment1.Persistence;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Todo> Todos { get; set; }
    
}
