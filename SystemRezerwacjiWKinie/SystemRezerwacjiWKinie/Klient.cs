using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    
    public enum zawod
    {
        uczen,
        student,
        dorosly
    }//potrzebne do znizek
    public class Klient : Osoba
    {
        
        public zawod zawod;
        public Klient(string imie, string nazwisko, string email, long NrTel, Plcie plec,zawod zawod) : base(imie, nazwisko, email, NrTel, plec)
        {
            
            this.zawod = zawod;
        }
        public override string ToString()
        {
            return base.ToString() + " metoda platnosci: ".ToString(); 
        }
    }
}
