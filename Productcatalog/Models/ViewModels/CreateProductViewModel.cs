using System.ComponentModel.DataAnnotations;

namespace Productcatalog.Models.ViewModels
{
    public class CreateProductViewModel
    {
        [Required(ErrorMessage = "Naam is verplicht")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Prijs is verplicht")]
        public decimal Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public List<Category>? Categories { get; set; }

    }
}
