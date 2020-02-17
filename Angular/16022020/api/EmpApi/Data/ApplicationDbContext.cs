using Microsoft.EntityFrameworkCore;
using EmpApi.Model;
namespace EmpApi.Data
{
    public class ApplicationDbContext: DbContext
    {
        
        public ApplicationDbContext(DbContextOptions opt): base(opt)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        
    }
}