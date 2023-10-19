using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Midterm_2234599.Data;
using Midterm_2234599.Model;

namespace Midterm_2234599.Pages
{
    public class EditModel : PageModel
    {
  
        [BindProperty]
        public Product Product { get; set; }

        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext db)
        {
            _context = db;
        }

        public void OnGet(string id)
        {
            Product = _context.Product.Find(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Product.Update(Product);
                _context.SaveChanges();

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
