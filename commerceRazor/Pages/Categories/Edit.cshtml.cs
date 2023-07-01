using commerceRazor.Data;
using commerceRazor.Model;


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace commerceRazor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public Category Category { get; set; }
        public void OnGet(int id)
        {
            Category = _context.Category.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Category.Update(Category);
                await _context.SaveChangesAsync();
                TempData["success"] = "Registro Actualizado correctamente!";
                return RedirectToPage("Index");
            }
            return Page();
        }

    }
}
