using Commerce.DataAcces;
using Commerce.DataAccess.Repository.IRepository;
using Commerce.Models;

namespace Commerce.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db)
            :base(db)
        {
            _db = db;
        }       

        public void Update(Category category)
        {
           _db.Categories.Update(category);
        }
    }
}
