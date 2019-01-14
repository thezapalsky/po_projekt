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


            Film f1 = new Film("Bumblebee", new TimeSpan(0, 114, 0), "film o transformersach...");
            Film f2 = new Film("Harry Potter", new TimeSpan(0, 140, 0), "film o harrym potterze...");
            //Console.WriteLine(f1);

            Sala s1 = new Sala(12, 10);
            Sala s2 = new Sala(12, 10);
            Sala s3 = new Sala(12, 10);
            Sala s4 = new Sala(12, 10);
            Sala s5 = new Sala(12, 10);//rzedy x miejsca w rzedzie
            


            Seans sea11 = new Seans(f1, s1, new DateTime(2020, 01, 11, 19, 0, 0));
            Seans sea12 = new Seans(f1, s1, new DateTime(2020, 01, 11, 16, 0, 0));
            Seans sea21 = new Seans(f2, s2, new DateTime(2020, 01, 11, 17, 0, 0));
            Seans sea22 = new Seans(f2, s2, new DateTime(2020, 01, 11, 14, 0, 0));
            //Console.WriteLine(sea1);
            Klient k1 = new Klient();
            Rezerwacja r1 = new Rezerwacja();
            Console.WriteLine("Ile miejsc chcesz zarezerwowac?");
            int wybor = int.Parse(Console.ReadLine());
            
            if (wybor >= 1)
            { 
                    Console.WriteLine("Wybierz film: 1-{0}\n2-{1}/n", f1.ToString(), f2.ToString());
                    int wybor2 = int.Parse(Console.ReadLine());
                    switch (wybor2)
                    {
                        case 1:
                            Console.WriteLine("Wybierz date seansu:\nNacisnij 1: {0} \nNacisnij 2: {1}", sea11.ToString(), sea12.ToString());
                            int wybor3 = int.Parse(Console.ReadLine());
                            switch (wybor3)
                            {
                                case 1:
                                    Console.WriteLine(sea11.sala.ToString());
                                    //TUTAJ POWINIEN BYC WYBOR MIEJSC!!!
                                    Console.WriteLine("Podaj imie:");
                                    k1.imie = Console.ReadLine();
                                    Console.WriteLine("Podaj nazwisko:");
                                    k1.nazwisko = Console.ReadLine();
                                    Console.WriteLine("Podaj adres email:");
                                    k1.email = Console.ReadLine();
                                    Console.WriteLine("Podaj numer telefonu:");
                                    k1.NrTel = Console.ReadLine();
                                    Console.WriteLine("Podaj plec (1-kobieta, 2-mezczyzna):");
                                    int wybor10 = int.Parse(Console.ReadLine());
                                    switch (wybor10)
                                    {
                                        case 1:
                                            k1.plec = Plcie.Kobieta;
                                            break;
                                        case 2:
                                            k1.plec = Plcie.Mezczyzna;
                                            break;
                                        default:
                                            Console.WriteLine("Zly znak!");
                                            break;
                                    }

                                    Console.WriteLine("Podaj ilosc biletow ulgowych:");
                                    wybor10 = int.Parse(Console.ReadLine());
                                    r1.LiczbaMiejscUlgowych += wybor10;
                                    Console.WriteLine("Podaj ilosc biletow normalnych:");
                                    wybor10 = int.Parse(Console.ReadLine());
                                    r1.LiczbaMiejscNormalnych += wybor10;
                                    Console.WriteLine("Wybierz metode platnosci (1-karta, 2-przelew bankowy, 3-gotowka):");
                                    wybor10 = int.Parse(Console.ReadLine());
                                    switch (wybor10)
                                    {
                                        case 1:
                                            k1.metoda = MetodaPlatnosci.Karta;
                                            break;
                                        case 2:
                                            k1.metoda = MetodaPlatnosci.Przelew;
                                            break;
                                        case 3:
                                            k1.metoda = MetodaPlatnosci.Gotowka;
                                            break;
                                        default:
                                            Console.WriteLine("Zly znak!");
                                            break;
                                    }
                                    r1.klient1 = k1;
                                    r1.seans1 = sea11;
                                    r1.obliczCene(r1.LiczbaMiejscUlgowych, r1.LiczbaMiejscNormalnych);

                                    break;
                            case 2:
                                    Console.WriteLine(sea12.sala.ToString());
                                    //WYBOR MIEJSC AGAIN!!!
                                    Console.WriteLine("Podaj imie:");
                                    k1.imie = Console.ReadLine();
                                    Console.WriteLine("Podaj nazwisko:");
                                    k1.nazwisko = Console.ReadLine();
                                    Console.WriteLine("Podaj adres email:");
                                    k1.email = Console.ReadLine();
                                    Console.WriteLine("Podaj numer telefonu:");
                                    k1.NrTel = Console.ReadLine();
                                    Console.WriteLine("Podaj plec (1-kobieta, 2-mezczyzna):");
                                    wybor10 = int.Parse(Console.ReadLine());
                                    switch (wybor10)
                                    {
                                        case 1:
                                            k1.plec = Plcie.Kobieta;
                                        break;
                                        case 2:
                                            k1.plec = Plcie.Mezczyzna;
                                        break;
                                        default:
                                            Console.WriteLine("Zly znak!");
                                        break;
                                    }

                                    Console.WriteLine("Podaj ilosc biletow ulgowych:");
                                    wybor10 = int.Parse(Console.ReadLine());
                                    r1.LiczbaMiejscUlgowych += wybor10;
                                    Console.WriteLine("Podaj ilosc biletow normalnych:");
                                    wybor10 = int.Parse(Console.ReadLine());
                                    r1.LiczbaMiejscNormalnych += wybor10;
                                    Console.WriteLine("Wybierz metode platnosci (1-karta, 2-przelew bankowy, 3-gotowka):");
                                    wybor10 = int.Parse(Console.ReadLine());
                                    switch (wybor10)
                                    {
                                        case 1:
                                            k1.metoda = MetodaPlatnosci.Karta;
                                            break;
                                        case 2:
                                            k1.metoda = MetodaPlatnosci.Przelew;
                                            break;
                                        case 3:
                                            k1.metoda = MetodaPlatnosci.Gotowka;
                                            break;
                                        default:
                                            Console.WriteLine("Zly znak!");
                                            break;
                                    }
                                    r1.klient1 = k1;
                                    r1.seans1 = sea12;
                                    r1.obliczCene(r1.LiczbaMiejscUlgowych, r1.LiczbaMiejscNormalnych);
                                    break;
                            }break;
                    case 2:
                        Console.WriteLine("Wybierz date seansu:\nNacisnij 1: {0} \nNacisnij 2: {1}", sea21.ToString(), sea22.ToString());
                        wybor3 = int.Parse(Console.ReadLine());
                        switch (wybor3)
                        {
                            case 1:
                                Console.WriteLine(sea21.sala.ToString());
                                //TUTAJ POWINIEN BYC WYBOR MIEJSC!!!
                                Console.WriteLine("Podaj imie:");
                                k1.imie = Console.ReadLine();
                                Console.WriteLine("Podaj nazwisko:");
                                k1.nazwisko = Console.ReadLine();
                                Console.WriteLine("Podaj adres email:");
                                k1.email = Console.ReadLine();
                                Console.WriteLine("Podaj numer telefonu:");
                                k1.NrTel = Console.ReadLine();
                                Console.WriteLine("Podaj plec (1-kobieta, 2-mezczyzna):");
                                int wybor10 = int.Parse(Console.ReadLine());
                                switch (wybor10)
                                {
                                    case 1:
                                        k1.plec = Plcie.Kobieta;
                                        break;
                                    case 2:
                                        k1.plec = Plcie.Mezczyzna;
                                        break;
                                    default:
                                        Console.WriteLine("Zly znak!");
                                        break;
                                }

                                Console.WriteLine("Podaj ilosc biletow ulgowych:");
                                wybor10 = int.Parse(Console.ReadLine());
                                r1.LiczbaMiejscUlgowych += wybor10;
                                Console.WriteLine("Podaj ilosc biletow normalnych:");
                                wybor10 = int.Parse(Console.ReadLine());
                                r1.LiczbaMiejscNormalnych += wybor10;
                                Console.WriteLine("Wybierz metode platnosci (1-karta, 2-przelew bankowy, 3-gotowka):");
                                wybor10 = int.Parse(Console.ReadLine());
                                switch (wybor10)
                                {
                                    case 1:
                                        k1.metoda = MetodaPlatnosci.Karta;
                                        break;
                                    case 2:
                                        k1.metoda = MetodaPlatnosci.Przelew;
                                        break;
                                    case 3:
                                        k1.metoda = MetodaPlatnosci.Gotowka;
                                        break;
                                    default:
                                        Console.WriteLine("Zly znak!");
                                        break;
                                }
                                r1.klient1 = k1;
                                r1.seans1 = sea11;
                                r1.obliczCene(r1.LiczbaMiejscUlgowych, r1.LiczbaMiejscNormalnych);

                                break;
                            case 2:
                                Console.WriteLine(sea22.sala.ToString());
                                //WYBOR MIEJSC AGAIN!!!
                                Console.WriteLine("Podaj imie:");
                                k1.imie = Console.ReadLine();
                                Console.WriteLine("Podaj nazwisko:");
                                k1.nazwisko = Console.ReadLine();
                                Console.WriteLine("Podaj adres email:");
                                k1.email = Console.ReadLine();
                                Console.WriteLine("Podaj numer telefonu:");
                                k1.NrTel = Console.ReadLine();
                                Console.WriteLine("Podaj plec (1-kobieta, 2-mezczyzna):");
                                wybor10 = int.Parse(Console.ReadLine());
                                switch (wybor10)
                                {
                                    case 1:
                                        k1.plec = Plcie.Kobieta;
                                        break;
                                    case 2:
                                        k1.plec = Plcie.Mezczyzna;
                                        break;
                                    default:
                                        Console.WriteLine("Zly znak!");
                                        break;
                                }

                                Console.WriteLine("Podaj ilosc biletow ulgowych:");
                                wybor10 = int.Parse(Console.ReadLine());
                                r1.LiczbaMiejscUlgowych += wybor10;
                                Console.WriteLine("Podaj ilosc biletow normalnych:");
                                wybor10 = int.Parse(Console.ReadLine());
                                r1.LiczbaMiejscNormalnych += wybor10;
                                Console.WriteLine("Wybierz metode platnosci (1-karta, 2-przelew bankowy, 3-gotowka):");
                                wybor10 = int.Parse(Console.ReadLine());
                                switch (wybor10)
                                {
                                    case 1:
                                        k1.metoda = MetodaPlatnosci.Karta;
                                        break;
                                    case 2:
                                        k1.metoda = MetodaPlatnosci.Przelew;
                                        break;
                                    case 3:
                                        k1.metoda = MetodaPlatnosci.Gotowka;
                                        break;
                                    default:
                                        Console.WriteLine("Zly znak!");
                                        break;
                                }
                                r1.klient1 = k1;
                                r1.seans1 = sea12;
                                r1.obliczCene(r1.LiczbaMiejscUlgowych, r1.LiczbaMiejscNormalnych);
                                break;
                        }break;
                    default:
                        Console.WriteLine("Zly wybor!");
                        break;
                    
                }Console.WriteLine(r1);
                                                                                    
            }
            else
            {
                Console.WriteLine("Bledny wybor!");
            }
        }
    }
}
