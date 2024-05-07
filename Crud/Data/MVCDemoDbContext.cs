using Crud.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
