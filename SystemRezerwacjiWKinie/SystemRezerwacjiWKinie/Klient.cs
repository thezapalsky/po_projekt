using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    //public enum znizka
    //{
    //    normalny,
    //    ulgowy
    //}//potrzebne do znizek
    public class Klient : Osoba
    {
        
        //public znizka znizka
        public Klient():base()
        {
            
            
        }
        public Klient(string imie, string nazwisko, string email, string NrTel) : base(imie, nazwisko, email, NrTel)
        {

        }
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
