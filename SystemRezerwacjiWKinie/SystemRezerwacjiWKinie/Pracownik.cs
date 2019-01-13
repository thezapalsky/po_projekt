using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    class Pracownik : Osoba
    {
        public int IdPracownika;
        public Pracownik(string imie, string nazwisko, string email, long NrTel, Plcie plec, int IdPracownika) : base(imie, nazwisko, email, NrTel, plec)
        {
            this.IdPracownika = IdPracownika;
        }
        public override string ToString()
        {
            return base.ToString() + " ID: " + IdPracownika.ToString();
        }
    }
}
