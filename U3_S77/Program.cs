using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S77
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(9, 11);

            Console.WriteLine("Dikdörtgenin alanı:" + dikdortgen.AlanHesapla());

            Console.WriteLine("Dikdörtgenin Çevrei:" + dikdortgen.CevreHesapla());

            Console.ReadLine();


        }

    }

    class Dikdortgen

    {
        private int a, b;

        public Dikdortgen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int AlanHesapla()
        {
            return a * b;

        }
        public int CevreHesapla()
        {

            return 2 * (a + b);
        }

    }
}
