using WebApplicationSample1.Models;
using WebApplicationSample1.Services;

namespace WebApplicationSample1.ServicesImplement
{
    public class CategoryService : ICategoryService
    {
        public List<CategoryViewModel> getAll()
        {
            return new List<CategoryViewModel>
            {
                new CategoryViewModel {Id = 1, Name = "Pen Drive", ParentId = 1 },
                new CategoryViewModel {Id = 2, Name = "Memory Card", ParentId = 1 },
                new CategoryViewModel {Id = 3, Name = "Mobile Phone" , ParentId = 1},
                new CategoryViewModel {Id = 4, Name = "Tablet", ParentId = 2},
                new CategoryViewModel {Id = 5, Name = "Desktop PC" , ParentId = 2} ,
            };
        }
    }
}
