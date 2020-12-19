using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumPoprawa
{
    class Lek
    {
        public bool OTC { get; }
        public static string Nazwa { get; set; }
        public static double CenaPodstawowa { get; set; }
        public static double Promocja { get; set; }

        public Lek(bool otc,string nazwa,double cenapodstawowa,double promocja)
        {
            OTC = otc;
            Nazwa = nazwa;
            CenaPodstawowa = cenapodstawowa;
            Promocja = promocja;
        }
        public static double Cena()
        {
            return CenaPodstawowa * Promocja;
        }
        public static void Sprzedaj(Lek obj)
        {
            if (obj.OTC == true)
            {
                Console.WriteLine("Podaj Numer recepty");
                string a = Console.ReadLine();
                if (Convert.ToString(a).Length == 10)
                {
                    Console.WriteLine(Nazwa,Cena());
                }
                else
                {
                    throw new ArgumentException("Nr recepty jest za krotki");
                }
            }
            
        }
    }
}
