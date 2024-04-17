using System.ComponentModel.DataAnnotations;

namespace Zaj1.Models
{
    public class film
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadz tytul")]
        public string Tytul { get; set; }
        public string Rezyser { get; set; }
        [StringLength(500)]
        public string Opis { get; set; }
        public string? Cena { get; set; }
        public DateTime DataDodania { get; set; }

        public string PlakatUrl { get; set; }

        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
