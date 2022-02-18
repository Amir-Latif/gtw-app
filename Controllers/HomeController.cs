using GTW_App.Data;
using GTW_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}