using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SystemRezerwacjiWKinie
{
    [Serializable]
    public class Film
    {
        public string nazwa;
        public string opis;
        TimeSpan czas_trwania;
        public string time;
        
        
        public string Nazwa
        {
            get
            {
                return nazwa;
            }

            set
            {
                nazwa = value;
            }
        }

        public Film()
        {
            this.nazwa = "";
            this.czas_trwania = new TimeSpan();
            this.opis = "";
        }
        public Film(string nazwa, TimeSpan czas_trwania, string opis)
        {
            this.nazwa = nazwa;
            this.czas_trwania = czas_trwania;
            this.opis = opis;
            this.time = czas_trwania.ToString();
        }
       
        //  public string Nazwa { get => nazwa; set => nazwa = value; }

        public override string ToString()
        {
            return "Nazwa: "+ this.nazwa + " Opis: " + this.opis + " Czas trwania: " + this.czas_trwania.ToString();
        }
    }
}
