namespace WebApplicationSample1.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Category = new CategoryViewModel();
        }
        public int Id { get; set; }
        public string Name { get; internal set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }

        public CategoryViewModel Category { get; set; }
    }
}
