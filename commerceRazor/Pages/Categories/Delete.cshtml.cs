using commerceRazor.Data;
using commerceRazor.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace commerceRazor.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public Category Category { get; set; }

        public void OnGet(int id)
        {
            Category = _context.Category.Find(id);
            // Category = _context.Category.FirstOrDefault(x => x.Id == id);
            // Category = _context.Category.SingleOrDefault(x => x.Id == id);
            // var  resultCategory = _context.Category.Where(x => x.Id == id).FirstOrDefault();
        }
        public async Task<IActionResult> OnPost()
        {
            var objfromDb = _context.Category.Find(Category.Id);
            if (objfromDb != null)
            {
                _context.Category.Remove(objfromDb);
                await _context.SaveChangesAsync();
                TempData["success"] = "Registro eliminado correctamente!";
                return RedirectToPage("Index");
            }
            return RedirectToPage("Index");

        }
    }
}
