using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample1.Models
{
    public class ProductSpecsModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "invalid field")]
        [StringLength(maximumLength: 200, MinimumLength = 2)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Rating { get; set; }
    }

    public class ProductDisplayViewModel
    {
        public bool Ann1 { get; }
        public bool Ann2 { get; }
        public int Ratings { get; set; }
        public ProductDisplayViewModel()
        {
            if (Ann1)
            {
                Ratings = 80;
            }
            else if (Ann2)
            {
                Ratings = 60;
            }
        }
    }
}
