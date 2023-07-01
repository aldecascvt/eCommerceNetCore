using commerceRazor.Model;
using Microsoft.EntityFrameworkCore;

namespace commerceRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Category> Category { get; set; }

    }
}
