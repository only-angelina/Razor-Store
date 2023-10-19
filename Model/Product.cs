using System.ComponentModel.DataAnnotations;

namespace Midterm_2234599.Model
{
    public class Product
    {
        [Key]
        [Display(Name = "ID")]
        public string ProductId { get; set; }

        [Required]
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Required]
        public string Quantity { get; set; }

        [Required]
        [Display(Name ="Buy Price")]
        public string BuyPrice { get; set; }

        [Required]
        [Display(Name = "Sell Price")]
        public string SellPrice { get; set; }
    }
}
