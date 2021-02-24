using Microsoft.EntityFrameworkCore;
using RazorPageDemo.Model;

namespace RazorPageDemo.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}