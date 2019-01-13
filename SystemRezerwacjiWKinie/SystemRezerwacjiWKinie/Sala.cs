using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRezerwacjiWKinie
{
    class Sala
    {
        int numer_sali;
        static int ilosc_sal;
        //0 -miejsce wolne, 1-miejsce zajęte
        int r;
        int m;
        int[,] miejsca;

        public int Numer_sali { get => numer_sali; set => numer_sali = value; }

        public Sala(int r,int m)//rzedy i miejsca
        {
            ilosc_sal++;
            this.r = r;
            this.m = m;
            Numer_sali = ilosc_sal;
            //miejsca = new int[][] { new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            miejsca = new int[r,m];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    miejsca[i, j] = 0;
                }
            }
        }

        public override string ToString()
        {
            string s="";
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    s+= miejsca[i, j].ToString()+" ";
                }
                s += "\n";
            }
            return "Numer Sali: " + Numer_sali.ToString() + " Miejsca (0-wolne;1-zajęte): \n"+s;
        }
    }
}
