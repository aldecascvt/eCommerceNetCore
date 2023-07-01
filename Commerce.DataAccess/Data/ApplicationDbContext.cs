
using Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Commerce.DataAcces
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
    }
}
