using Microsoft.EntityFrameworkCore;

namespace Zaj1.Models
{
    public class FilmyConetext: DbContext
    {
        public FilmyConetext(DbContextOptions options) : base(options)
        {
        }

        DbSet<film> Filmy { get; set; }
        DbSet<Kategoria> Kategorie { get; set; }

       
    }
}
