using Microsoft.AspNetCore.Mvc;
using Zaj1.Sesion;

namespace Zaj1.Models
{
    public static class MenadzerKoszyka
    {
        public static int UsunZKoszyka(ISession session, int id)
        {
            var koszyk = PobierzKoszyk(session);

            var usuwanyFilm = koszyk.Find(i => i.Film.Id == id);

            int ilosc = 0;

            if (usuwanyFilm == null)
            {
                return ilosc;
            }

            if (usuwanyFilm.Ilosc > 1)
            {
                usuwanyFilm.Ilosc--;

                ilosc = usuwanyFilm.Ilosc;
            }

            else
            {
                koszyk.Remove(usuwanyFilm);
            }

            session.SetObjectAsJson(Consts.KluczSesji, koszyk);

            return ilosc;

        }

        private static List<ElementKoszyka> PobierzKoszyk(ISession session)
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(session, Consts.KluczSesji);

            if (koszyk == null)
            {
                koszyk = new List<ElementKoszyka>();
            }
            return koszyk;
        }

        public static void DodajDoKoszyka(ISession session, FilmyContext db, int filmId)
        {
            var koszyk = PobierzKoszyk(session);

            var szukanyFilm = koszyk.Find(i => i.Film.Id == filmId);

            if (szukanyFilm != null)
            {
                szukanyFilm.Ilosc++;
            }
            else
            {
                var filmZbazy = db.Filmy.Where(f => f.Id == filmId).FirstOrDefault();

                if (filmZbazy != null)
                {
                    var elementKoszyka = new ElementKoszyka
                    {
                        Film = filmZbazy,
                        Ilosc = 1,
                        Wartosc = filmZbazy.Cena
                    };

                    koszyk.Add(elementKoszyka);
                }
            }

            SessionHelper.SetObjectAsJson(session, Consts.KluczSesji, koszyk);
        }

        public static int IloscElemKoszyka(ISession session)
        {
            var koszyk = PobierzKoszyk(session);

            return koszyk.Sum(i => i.Ilosc);
        }
    }
}
