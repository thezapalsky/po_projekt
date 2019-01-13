﻿using System;
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

            Sala s1 = new Sala(12,10); //rzedy x miejsca w rzedzie
            Console.WriteLine(s1);

            Seans sea1 = new Seans(f1, s1, new DateTime(2020, 01, 11, 19, 0, 0));
            Console.WriteLine(sea1);

            Console.ReadKey();
        }
    }
}
