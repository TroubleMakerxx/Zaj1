using Microsoft.AspNetCore.Mvc;

namespace Zaj1.Models
{
    public class ElementKoszyka 
    {
        public film Film { get; set; }
        public int Ilosc { get; set; }

        public decimal Wartosc { get; set;}

    }
}
