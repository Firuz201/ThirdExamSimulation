using Microsoft.EntityFrameworkCore;
using ThirdExamSimulation.Areas.Admin.Models;

namespace ThirdExamSimulation.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees;
        public DbSet<Position> Positions;
        
    }
}
