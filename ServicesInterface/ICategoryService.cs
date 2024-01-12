using WebApplicationSample1.Models;

namespace WebApplicationSample1.Services
{
    public interface ICategoryService
    {
        List<CategoryViewModel> getAll();
    }

}
