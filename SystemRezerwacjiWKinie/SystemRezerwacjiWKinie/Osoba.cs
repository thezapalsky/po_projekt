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
        private string imie;
        private string nazwisko;
        private string email;
        private string nrTel;
        private Plcie plec;

        public string Imie
        {
            get
            {
                return imie;
            }

            set
            {
                imie = value;
            }
        }

        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }

            set
            {
                nazwisko = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string NrTel
        {
            get
            {
                return nrTel;
            }

            set
            {
                nrTel = value;
            }
        }

        public Plcie Plec
        {
            get
            {
                return plec;
            }

            set
            {
                plec = value;
            }
        }

        /*     public string Imie { get => imie; set => imie = value; }
               public string Nazwisko { get => nazwisko; set => nazwisko = value; }
               public string Email { get => email; set => email = value; }
               public string NrTel1 { get => NrTel; set => NrTel = value; }
               internal Plcie Plec { get => plec; set => plec = value; } */

        public Osoba()
        {
            this.Imie = "";
            this.Nazwisko = "";
            this.Email = "";
            this.NrTel = "";
        }
        public Osoba(string imie, string nazwisko, string email, string NrTel)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Email = email;
            this.NrTel = NrTel;
        }
        public Osoba(string imie,string nazwisko, string email,string NrTel, Plcie plec)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Email = email;
            this.NrTel = NrTel;
            this.Plec = plec;
        }
        public override string ToString()
        {
            return this.Imie + " " + this.Nazwisko + " " + this.Email + " " + this.NrTel; 
        }
    }
}
