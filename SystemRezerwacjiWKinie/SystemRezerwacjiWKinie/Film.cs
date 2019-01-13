using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    public class Film
    {
        string nazwa;
        TimeSpan czas_trwania;
        string opis;

        public Film(string nazwa, TimeSpan czas_trwania, string opis)
        {
            this.Nazwa = nazwa;
            this.czas_trwania =czas_trwania;
            this.opis = opis;
        }

        public string Nazwa { get => nazwa; set => nazwa = value; }

        public override string ToString()
        {
            return "Nazwa: "+this.Nazwa + " Opis: " + this.opis + " Czas trwania: " + this.czas_trwania.ToString();
        }
    }
    
}
