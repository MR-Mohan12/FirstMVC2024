using FirstMVC2024.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVC2024.Context
{
    public class EmployeeDbContext : DbContext 
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) 
        {

        }

        public DbSet<Employee> Employees  { get; set; }

        

    }
}
