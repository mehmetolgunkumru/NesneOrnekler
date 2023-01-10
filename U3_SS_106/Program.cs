using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_106
{
    public abstract class Kutuphane
    {
        public abstract void Oku();
    }
    public class Kıtap : Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("OKundu");
        }

        public class Dergı : Kutuphane
        {
            public override void Oku()
            {
                Console.WriteLine("OKundu");
            }
        }

        public class ansıklopedı : Kutuphane
        {
            public override void Oku()
            {
                Console.WriteLine("OKundu");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kıtap oto = new Kıtap
            {

            };
            oto.Oku();
            {
            }
        }
    }
}
