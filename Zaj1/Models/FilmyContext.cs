﻿using Microsoft.EntityFrameworkCore;

namespace Zaj1.Models
{
    public class FilmyContext: DbContext
    {
        public FilmyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<film> Filmy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategoria>().HasData(
                new Kategoria() { Id = 1, Nazwa = "Akcja", Opis = "Filmy pełne ekscytujących scen akcji" },
                new Kategoria() { Id = 2, Nazwa = "Science Fiction", Opis = "Filmy o niesamowitej technologii, podróżach kosmicznych itp." },
                new Kategoria() { Id = 3, Nazwa = "Dramat", Opis = "Filmy poruszające emocje i przedstawiające złożone historie" },
                new Kategoria() { Id = 4, Nazwa = "Western", Opis = "Filmy osadzone w dzikim Zachodzie z charakterystycznymi elementami" },
                new Kategoria() { Id = 5, Nazwa = "Thriller", Opis = "Filmy z napięciem i elementami zagadki" },
                new Kategoria() { Id = 6, Nazwa = "Komedia", Opis = "Filmy, które mają za zadanie rozbawić widza" }
            );

            modelBuilder.Entity<film>().HasData(
                new film() { Id = 1, Tytul = "Incepcja", Rezyser = "Christopher Nolan", Opis = "Thriller science fiction o kradzieży danych umysłu", Cena = 25, DataDodania = DateTime.Now, KategoriaId = 2, PlakatUrl = "MagicHeal.jpg" },
                new film() { Id = 2, Tytul = "Matrix", Rezyser = "Lana Wachowski, Lilly Wachowski", Opis = "Film akcji o walce ludzi przeciwko maszynom", Cena = 22, DataDodania = DateTime.Now, KategoriaId = 2, PlakatUrl = "Solo.png" },
                new film() { Id = 3, Tytul = "Shawshank Redemption", Rezyser = "Frank Darabont", Opis = "Dramat więzienny oparty na noweli Stephena Kinga", Cena = 18, DataDodania = DateTime.Now, KategoriaId = 3, PlakatUrl = "Shrek.jpg" },
                new film() { Id = 4, Tytul = "Django Unchained", Rezyser = "Quentin Tarantino", Opis = "Western o niewolnictwie i zemście", Cena = 23, DataDodania = DateTime.Now, KategoriaId = 3, PlakatUrl = "Exorcisto.jpg" },
                new film() { Id = 5, Tytul = "Interstellar", Rezyser = "Christopher Nolan", Opis = "Epicki film science fiction o podróży międzygwiezdnej", Cena = 28, DataDodania = DateTime.Now, KategoriaId = 2, PlakatUrl = "Harry.jpg" }
            );

        }

    }
}
