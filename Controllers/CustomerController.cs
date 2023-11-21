using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using WebApplicationSample1.Models;

namespace WebApplicationSample1.Controllers
{

    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [Route("/chinhsach")]
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Demo()
        {
            int pageIndex = 0;
            int pageSize = 10;

            var lst = _service.Paging().Skip(pageIndex * pageSize).Take(pageSize);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DemoSubmit(CustomerModel model)
        {
            string mess = string.Empty;
            if (ModelState.IsValid)
            {
                mess = "Success " + model.Name;
            }
            else
            {
                mess = "Fail";
            }
            return Content(mess);
        }

        [HttpPost]
        public JsonResult DemoSubmit2(int id, int age, string name)
        {
            //var submitModel = new CustomerModel();
            //submitModel.Id = id;
            //submitModel.Name = name;
            //submitModel.Age = age;

            //_service.Submit(submitModel); 
            return Json(id);
        }
    }
}
