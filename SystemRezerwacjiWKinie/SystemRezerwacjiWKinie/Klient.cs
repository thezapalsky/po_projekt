using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    
    public enum znizka
    {
        normalny,
        ulogwy
    }//potrzebne do znizek
    public class Klient : Osoba
    {
        
        public znizka znizka;
        public Klient(string imie, string nazwisko, string email, long NrTel, Plcie plec,znizka znizka) : base(imie, nazwisko, email, NrTel, plec)
        {
            
            this.znizka = znizka;
        }
        public override string ToString()
        {
            return base.ToString() + " Rodzaj biletu: "+znizka; 
        }
    }
}
