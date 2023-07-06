using Commerce.DataAcces;
using Commerce.DataAccess.Repository.IRepository;
using Commerce.Models;

namespace Commerce.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
            :base(db)
        {
            _db = db;
        }       

        public void Update(Product product)
        {
           _db.Products.Update(product);
        }
    }
}
