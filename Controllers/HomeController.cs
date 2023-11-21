using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationSample1.Models;

namespace WebApplicationSample1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult DisplayDemo()
        {
            // tinh toan, logic
            var resp = new DisplayDemoModel();

            resp.Name = "Nguyen van A";
            resp.Age = "18";

            ViewBag.Age = "18";
            ViewData["Age"] = "18";
            
            TempData["Title"] = "Demo";

            return View(resp);
        }

        public IActionResult DisplayName()
        {
            return PartialView();
        }


        public IActionResult Index()
        {
            return View();
        }

        [Route("/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}