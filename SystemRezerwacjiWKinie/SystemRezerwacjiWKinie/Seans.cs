using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    class Seans
    {
        static int ilosc_seansow=0; 
        string idSeansu;
        Film film;
        Sala sala;
        DateTime data_rozpoczecia;

        public Seans(Film film, Sala sala, DateTime data_rozpoczecia)
        {
            ilosc_seansow++;
            idSeansu = "SE" + ilosc_seansow.ToString().PadLeft(5, '0');
            this.film = film;
            this.sala = sala;
            this.data_rozpoczecia = data_rozpoczecia;
        }

        public override string ToString()
        {
            return "Seans o numerze: " + idSeansu + "\nFilm: " + film.Nazwa+"\nSala: " + sala.Numer_sali.ToString() + "\nData rozpoczecia: " + data_rozpoczecia.ToString();
        }


    }
}
