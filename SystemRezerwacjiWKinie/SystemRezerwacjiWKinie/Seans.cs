using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    public class Seans
    {
        static int ilosc_seansow=0; 
        string idSeansu;
        Film film;
        public Sala sala;
        DateTime data_rozpoczecia;


        public Seans()
        {
            idSeansu = "";
            this.film = new Film();
            this.sala = new Sala();
            data_rozpoczecia = new DateTime();
        }
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
            return film.nazwa+" Sala " + sala.Numer_sali.ToString() + " Data: " + data_rozpoczecia.ToString();
        }


    }
}
