using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Zaj1.Models
{
    public class Kategoria
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kategorii")]
        public string Nazwa { get; set; }

        public string Opis { get; set; }

        public ICollection<film> Filmy { get; set; }
    }
}
