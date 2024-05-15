using Microsoft.AspNetCore.Mvc;
using Zaj1.Sesion;

namespace Zaj1.Models
{
    public static class MenadzerKoszyka
    {
        public static int UsunzKoszyka(ISession session, int id)
        {
            var koszyk = PobierzKoszyk(session);
            var usuwanyFilm = koszyk.Find(i => i.Film.Id == id);
        }

        private static object PobierzKoszyk(ISession session)
        {
            List<ElementKoszyka> koszyk=SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(session, Consts.KluczSesji);
            if (koszyk == null)
            {
                koszyk = new List<ElementKoszyka>();
            }
            return koszyk;
        }
    }
}
