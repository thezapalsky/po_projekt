using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    //public enum znizka
    //{
    //    normalny,
    //    ulgowy
    //}
    public class Rezerwacja
    {
        //public int LiczbaMiejscUlgowych;
        //public int LiczbaMiejscNormalnych;
        public Klient klient1;
        public Seans seans1;
        bool ulga;
        int rzad;
        int miejsce;
        //static double cena = 0;

        public Rezerwacja()
        {
            this.klient1 = new Klient();
            this.seans1 = new Seans();
            ulga = false;
            rzad = 0;
            miejsce = 0;
            //this.LiczbaMiejscNormalnych = 0;
            //this.LiczbaMiejscUlgowych = 0;

        }
        
        public Rezerwacja(Klient klient1, Seans seans1, int rzad, int miejsce,bool ulga)
        {
            if(seans1.sala.Miejsca[rzad-1,miejsce-1]==0)
            {
                this.klient1 = klient1;
                this.seans1 = seans1;
                this.ulga = ulga;
                this.rzad = rzad+1;
                this.miejsce = miejsce+1;
                //this.LiczbaMiejscUlgowych = LiczbaMiejscUlgowych;
                //this.LiczbaMiejscNormalnych = LiczbaMiejscNormalnych;
                //cena = LiczbaMiejscUlgowych * 15 + LiczbaMiejscNormalnych * 20;
                seans1.sala.Miejsca[rzad-1, miejsce-1] = 1;
            }
            else
            {
                Console.WriteLine("blad - wybrane miejsce jest zajete");
            }
        }

        public bool Ulga { get => ulga; set => ulga = value; }

        //public void obliczCene(int LiczbaMiejscUlgowych,int LiczbamiejscNormalnych)
        //{
        //    cena = LiczbaMiejscUlgowych * 15 + LiczbamiejscNormalnych * 20;
        //}
        public override string ToString()
        {
            if(ulga)
            {
                return klient1.ToString()+" ulgowy\nrząd: "+rzad+" miejsce: "+ miejsce+ "\n" + seans1.ToString();//+"\nDo zaplacenia: "+cena.ToString()+"zl";

            }
            return klient1.ToString() + "\nrząd: " + rzad + " miejsce: " + miejsce + "\n" + seans1.ToString();//+"\nDo zaplacenia: "+cena.ToString()+"zl";


        }



    }
}
