using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Midterm_2234599.Data;
using Midterm_2234599.Model;

namespace Midterm_2234599.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty] 
        public Product Product { get; set; }

        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Product.Add(Product);
                _context.SaveChanges();

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
