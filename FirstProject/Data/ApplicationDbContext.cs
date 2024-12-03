using FirstProject.Model;
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern_ASPNetCore_WebAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }public DbSet<Student> Students { get; set; }
}
