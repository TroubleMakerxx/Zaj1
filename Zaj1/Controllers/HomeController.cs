using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Zaj1.Models;

namespace Zaj1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        FilmyContext db;

        public HomeController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }

        public IActionResult Index()
        {
            var kategorie = db.Kategorie.ToList();
            return View(kategorie);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
