using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramidUcgeni
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int baslangicSayisi;
            Console.Write("Baslangıc Sayisi Giriniz:");
            baslangicSayisi=Convert.ToInt32(Console.ReadLine());

            int lastFaktoriyel = 0;
            
            for (int i = 1; i <= baslangicSayisi; i++)

           {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(FaktoriyelHesaplama(lastFaktoriyel + 1));
                    Console.Write(" ");
                    lastFaktoriyel++;
                }

                Console.WriteLine("");

            }

            Console.Read();

        }

        public static int FaktoriyelHesaplama(int a)
        {
            if (a == 0)
                return 1;
            else
                return FaktoriyelHesaplama(a - 1) * a;
}

    }
}
