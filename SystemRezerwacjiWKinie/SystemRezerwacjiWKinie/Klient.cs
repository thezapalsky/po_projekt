using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{

    public enum MetodaPlatnosci
    {
        Przelew,
        Karta,
        Gotowka
    }
    //public enum znizka
    //{
    //    normalny,
    //    ulgowy
    //}//potrzebne do znizek
    public class Klient : Osoba
    {
        
        //public znizka znizka;
        public MetodaPlatnosci metoda;
        public Klient():base()
        {
            
            this.metoda = (MetodaPlatnosci)0;
            
        }
        public Klient(string imie, string nazwisko, string email, string NrTel, Plcie plec,MetodaPlatnosci metoda) : base(imie, nazwisko, email, NrTel, plec)
        {
            
            
            this.metoda = metoda;
        }
        public override string ToString()
        {
            return base.ToString() + "Metoda platnosci: "+metoda.ToString(); 
        }
    }
}
