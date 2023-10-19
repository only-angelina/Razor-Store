using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Midterm_2234599.Data;
using Midterm_2234599.Model;

namespace Midterm_2234599.Pages
{
    public class StockModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        public List<Product> Products { get; set; }

        public StockModel(ApplicationDbContext db)
        {
            _context = db;
        }


        public void OnGet()
        {
            Products = _context.Product.ToList();
            /*
            if (Products.Count < 10) 
            {
                
            }
            */
        }

       
    }
}
