using Commerce.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
    }
}
