using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApplicationSample1.Models;
using WebApplicationSample1.Services;

namespace WebApplicationSample1.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Paging()
        {

            return View();
        }

        [Route("sanpham/{id}")]
        public IActionResult Details(int id)
        {
            var lstItems = _productService.getAll();

            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProductSpecsModel model)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                message = "product " + model.Name + " Quantity " + model.Quantity.ToString() + " Rating " + model.Rating.ToString() + " created successfully";
            }
            else
            {
                ModelState.AddModelError("", "Fail to create");
                return View(model);
            }
            return Content(message);
        }

    }
}
