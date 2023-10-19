using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Midterm_2234599.Data;
using Midterm_2234599.Model;

namespace Midterm_2234599.Pages
{
    
    public class IndexModel : PageModel
    {
        

        private readonly ApplicationDbContext _context;
        public List<Product> Products { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _context = db;
        }


        public void OnGet()
        {
            Products = _context.Product.ToList();
        }
    }
}