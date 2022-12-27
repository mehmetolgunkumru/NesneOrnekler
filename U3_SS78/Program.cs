using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS78
{
    class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire();

            Console.WriteLine("dairenin alanı:" + daire.Alan(4));
            Console.WriteLine("dairenin çevresi:" + daire.Cevre(6));

            Console.ReadLine();
        }
    }

    class Daire
    {
        public double Alan(double r)
        {
            return 3.14 * r * r;
        }

        public double Cevre(double r)
        {
            return (2 * Math.PI * r);

        }
    }
}
