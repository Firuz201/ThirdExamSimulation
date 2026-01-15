using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ThirdExamSimulation.Areas.Admin.Models;

namespace ThirdExamSimulation.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> Employees;
    public DbSet<Position> Positions;
    
}
