using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    class Film
    {
        string nazwa;
        TimeSpan czas_trwania;
        string opis;

        public Film(string nazwa, TimeSpan czas_trwania, string opis)
        {
            this.nazwa = nazwa;
            this.czas_trwania =czas_trwania;
            this.opis = opis;
        }

        public override string ToString()
        {
            return "Nazwa: "+this.nazwa + " Opis: " + this.opis + " Czas trwania: " + this.czas_trwania.ToString();
        }
    }
    
}
