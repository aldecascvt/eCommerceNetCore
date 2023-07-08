using Commerce.DataAcces;
using Commerce.DataAccess.Repository.IRepository;
using Commerce.Models;

namespace Commerce.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var productFromDb = _db.Products.FirstOrDefault(p => p.Id == product.Id);
            if (productFromDb != null)
            {
                productFromDb.Title = product.Title;
                productFromDb.Description = product.Description;
                productFromDb.CategoryId = product.CategoryId;
                productFromDb.ISBN = product.ISBN;
                productFromDb.Price = product.Price;
                productFromDb.ListPrice = product.ListPrice;
                productFromDb.Price100 = product.Price100;
                productFromDb.Price50 = product.Price50;
                productFromDb.Author = product.Author;
                productFromDb.CoverTypeId = product.CoverTypeId;               

                if (product.ImageUrl != null)
                {
                    productFromDb.ImageUrl = product.ImageUrl;
                }
            }
           
        }
    }
}
