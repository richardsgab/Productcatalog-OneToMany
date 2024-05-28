using System.ComponentModel.DataAnnotations;

namespace Productcatalog.Models
{
    public class Category
    {
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
