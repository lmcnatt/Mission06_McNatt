using Microsoft.AspNetCore.Mvc;
using Mission06_McNatt.Models;
using System.Diagnostics;

namespace Mission06_McNatt.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;

        public HomeController(MovieCollectionContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Movie response)
        {
            _context.Movies.Add(response); // Add record to the database
            _context.SaveChanges();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
