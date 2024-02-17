using Microsoft.AspNetCore.Mvc;
using Mission06_Halls.Models;
using System.Diagnostics;

namespace Mission06_Halls.Controllers
{
    public class HomeController : Controller
    {
        private MoviesApplicationContext _context;

        public HomeController(MoviesApplicationContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View("Movies");
        }

        [HttpPost]
        public IActionResult Movies(Application response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }

        public IActionResult About() 
        { 
            return View();
        }
    }
}
