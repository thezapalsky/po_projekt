using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SystemRezerwacjiWKinie
{
    class XMLManager
    {

        public static StreamWriter CreateStreamWriter(string nazwaPliku)
        {
            StreamWriter sw = new StreamWriter(nazwaPliku);
            return sw;
        }

        public static void ZapiszXML(StreamWriter sw, List<Film> F)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));
            
            serializer.Serialize(sw, F);
            
            
        }
        public static Object OdczytajXML(string nazwaPliku)
        {
            List<Film> filmOdczytany;

            try
            {
                TextReader tr = new StreamReader(nazwaPliku);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));
                filmOdczytany = (List<Film>)serializer.Deserialize(tr);
                
                for(int i = 0; i < filmOdczytany.Count(); i++)
                {
                    Film NewFilm = filmOdczytany[i];
                    Console.WriteLine("Film odczytany: " + NewFilm.nazwa + " " + NewFilm.opis + " " + NewFilm.time);
                }
                         
                tr.Close();
                return filmOdczytany;
            }
            catch (FileNotFoundException)
            {
                SystemSounds.Exclamation.Play();
                Console.WriteLine("Plik {0} nie istnieje!!!", nazwaPliku);
            }
            return null;
        }
    }
}
