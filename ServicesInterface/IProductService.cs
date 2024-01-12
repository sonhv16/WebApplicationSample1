using WebApplicationSample1.Models;

namespace WebApplicationSample1.Services
{
    public interface IProductService
    {
        List<ProductViewModel> getAll();
    }

}
