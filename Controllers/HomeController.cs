using GTW_App.Data;
using Microsoft.AspNetCore.Mvc;

namespace GTW_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly GtwDbContext _db;

        public HomeController(GtwDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            ViewData["Products"] = _db.Products.ToArray();

            return View();
        }
        public IActionResult Product(int id)
        {
            var product = _db.Products.FirstOrDefault(e => e.Id == id);

            if (product != null) return View(product);
            else return RedirectToAction(nameof(Error));

        }

        public IActionResult Error()
        {
            return View();
        }
    }
}