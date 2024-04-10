using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zaj1.Models;

namespace Zaj1.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;

        public FilmyController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }

        public IActionResult Lista(string nazwaKategorii)
        {
            var kategorie = db.Kategorie
                .Include("Filmy")
                .Where(kategoria => kategoria.Nazwa.ToUpper() == nazwaKategorii.ToUpper())
                .Single();
            var filmy = kategorie.Filmy.ToList();
            return View(filmy);
        }

        public IActionResult Szczegoly(int idFilmu)
        {
            var kategoria = db.Kategorie.Find(db.Filmy.Find(idFilmu).KategoriaId);
            var film = db.Filmy.Find(idFilmu);
            return View(film);
        }
    }
}
