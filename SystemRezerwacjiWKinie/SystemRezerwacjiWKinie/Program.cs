using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Adam","Małysz","amalysz@skoki.xd",123321123, Plcie.Mezczyzna);
            Console.WriteLine(p1);

            Klient k1 = new Klient("Mariusz", "Pudzianowski", "mpudzian@pu.dzian", 111222333, Plcie.Mezczyzna, znizka.ulogwy);
            Console.WriteLine(k1);

            Film f1 = new Film("Bumblebee", new TimeSpan(0, 114,0), "film o transormersach bla bla...");
            Console.WriteLine(f1);

            Console.ReadKey();
        }
    }
}
