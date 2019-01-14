using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    public enum Plcie
    {
        Kobieta,
        Mezczyzna
    }
        
   public class Osoba
    {
        public string imie;
        public string nazwisko;
        public string email;
        public string NrTel;
        public Plcie plec;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Email { get => email; set => email = value; }
        public string NrTel1 { get => NrTel; set => NrTel = value; }
        internal Plcie Plec { get => plec; set => plec = value; }

        public Osoba()
        {
            this.imie = "";
            this.nazwisko = "";
            this.email = "";
            this.NrTel = "";
        }

        public Osoba(string imie,string nazwisko, string email,string NrTel, Plcie plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.email = email;
            this.NrTel = NrTel;
            this.plec = plec;
        }
        public override string ToString()
        {
            return this.imie+" "+this.nazwisko+" "+this.email+" "+this.NrTel+" "+this.plec.ToString();
        }
    }
}
