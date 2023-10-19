using Midterm_2234599.Model;
using Microsoft.EntityFrameworkCore;

namespace Midterm_2234599.Data
{
    public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
        public DbSet<Product> Product { get; set; }
    }
}
