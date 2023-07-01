
using commerceRazor.Data;
using commerceRazor.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Web.Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}
