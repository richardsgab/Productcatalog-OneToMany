using Microsoft.EntityFrameworkCore;

namespace Productcatalog.Models.ViewModels
{
    [Keyless]
    public class ProductenViewModel
    {
        public List<Product> Product { get; set; }
        public List<Category> Categories { get; set; }
        public int GeselecteerdeCategoryId { get; set; }
    }
}
