using WebApplicationSample1.Models;
using WebApplicationSample1.Services;

namespace WebApplicationSample1.ServicesImplement
{
    public class ProductService : IProductService
    {
        public List<ProductViewModel> getAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "Pen Drive" },
                new ProductViewModel {Id = 2, Name = "Memory Card" },
                new ProductViewModel {Id = 3, Name = "Mobile Phone" },
                new ProductViewModel {Id = 4, Name = "Tablet" },
                new ProductViewModel {Id = 5, Name = "Desktop PC" } ,
            };
        }
    }
}
