using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    
    class Pracownik : Osoba
    {
        private int IdPracownika;
        static int id_pracownikow;

        static Pracownik()
        {
            id_pracownikow = 0;
        }
        public Pracownik(string imie, string nazwisko, string email, long NrTel, Plcie plec) : base(imie, nazwisko, email, NrTel, plec)
        {
            id_pracownikow++;
            this.IdPracownika = id_pracownikow;
        }
        public override string ToString()
        {
            return base.ToString() + " ID: " + IdPracownika.ToString();
        }
    }
}
