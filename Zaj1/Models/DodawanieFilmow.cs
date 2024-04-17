using Microsoft.AspNetCore.Mvc;

namespace Zaj1.Models
{
    public class DodawanieFilmow 
    {
        public film film { get; set; }
        public List<Kategoria> Kategorie { get; set; }
    }
}
