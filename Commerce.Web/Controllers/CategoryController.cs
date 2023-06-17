using Commerce.Web.Data;
using Commerce.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ViewBag.ProductDescription = "Libros nuevos"; 
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
