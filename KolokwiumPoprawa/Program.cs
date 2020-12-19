using System;

namespace KolokwiumPoprawa
{
    class Program
    {
        public static void func(ref int pkt, string odp)
        {
            pkt++;
        }
        static void Main(string[] args)
        {
            string a;
            int punkty=0;
            do
            {
                a = Console.ReadLine();
                if ((String.Compare(a, "tak")>0)) ;
                {
                    func(ref punkty,a);
                }
            } while (punkty == 3);

            Lek Apap = new Lek(true, "Apap", 10, 0.2);

        }
    }
}
