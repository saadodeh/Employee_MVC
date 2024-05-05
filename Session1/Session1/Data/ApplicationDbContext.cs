using Microsoft.EntityFrameworkCore;
using Session1.Models;

namespace Session1.Data
{
    
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EHIAKM6;database = Employee;trusted_connection=true;TrustServerCertificate=True");
        }

    }
}
