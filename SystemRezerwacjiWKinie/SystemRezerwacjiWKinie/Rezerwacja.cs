using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    public enum znizka
    {
        normalny,
        ulgowy
    }
    public class Rezerwacja
    {
        public int LiczbaMiejscUlgowych;
        public int LiczbaMiejscNormalnych;
        public Klient klient1;
        public Seans seans1;
        static double cena = 0;
        
        public Rezerwacja()
        {
            this.klient1 = new Klient();
            this.seans1 = new Seans();
            this.LiczbaMiejscNormalnych = 0;
            this.LiczbaMiejscUlgowych = 0;

        }
        
        public Rezerwacja(Klient klient1, Seans seans1,int LiczbaMiejscUlgowych,int LiczbaMiejscNormalnych)
        {
            this.klient1 = klient1;
            this.seans1 = seans1;
            this.LiczbaMiejscUlgowych = LiczbaMiejscUlgowych;
            this.LiczbaMiejscNormalnych = LiczbaMiejscNormalnych;
            cena = LiczbaMiejscUlgowych * 15 + LiczbaMiejscNormalnych * 20;
        }
        public void obliczCene(int LiczbaMiejscUlgowych,int LiczbamiejscNormalnych)
        {
            cena = LiczbaMiejscUlgowych * 15 + LiczbamiejscNormalnych * 20;
        }
        public override string ToString()
        {
            return klient1.ToString() + "\n " + seans1.ToString()+"\nDo zaplacenia: "+cena.ToString()+"zl";
        }
        


    }
}
