namespace EmployeeAPI.Context
{
    using EmployeeAPI.Models;
    using Microsoft.EntityFrameworkCore;
    
    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
