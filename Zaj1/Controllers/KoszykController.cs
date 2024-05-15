using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography.X509Certificates;
using Zaj1.Models;
using Zaj1.Sesion;

namespace Zaj1.Controllers
{
    public class KoszykController : Controller
    {
        FilmyContext db;

        public KoszykController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);

            // Check if koszyk is not null
            if (koszyk != null)
            {
                ViewBag.CalaSuma = koszyk.Sum(f => f.Film.Cena * f.Ilosc);
            }
            else
            {
                // If koszyk is null, set ViewBag.CalaSuma to 0 or any other default value
                ViewBag.CalaSuma = 0; // or any other default value
            }

            return View(koszyk);
        }

        public IActionResult Kup(int id)
        {
            var film = db.Filmy.Where(f => f.Id == id).Single();

            if (SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji) == null)
            {
                List<ElementKoszyka> koszyk = new() {
                    new ElementKoszyka
                    {
                        Film = film,
                        Ilosc=1,
                        Wartosc=film.Cena
                    }
                };
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KluczSesji, koszyk);
            }
            else
            {
                List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);

                var index = koszyk.FindIndex(i => i.Film.Id == id);
                if (index != -1)
                {
                    koszyk[index].Ilosc++;
                }
                else
                {
                    koszyk.Add(new ElementKoszyka
                    {
                        Film = film,
                        Ilosc = 1,
                        Wartosc = film.Cena
                    });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KluczSesji, koszyk);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Usun(int id)
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);
            var index = koszyk.FindIndex(i => i.Film.Id == id);
            koszyk.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KluczSesji, koszyk);
            return RedirectToAction("Index");
        }

        public int PobierzIloscRzeczywKoszyku()
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);
            if (koszyk == null)
            {
                koszyk = new List<ElementKoszyka>();
            }
            return koszyk.Sum(i => i.Ilosc);
        }

        public async Task<IViewComponentHelper> InvokeAsync()
        {
           ViewBag.CalaSuma = PobierzIloscRzeczywKoszyku();

            return await Task.FromResult((IViewComponentHelper)View("_Menu", db.Kategorie.ToList()));
        }
    }
    
}
