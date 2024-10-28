using Microsoft.EntityFrameworkCore;
using SampleCRUDusingDotnet.Models.Entities;

namespace SampleCRUDusingDotnet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
