using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = szamotker("Adja meg az első számot: ");
            int b = szamotker("Adja meg a második számot: ");
            
            int c = a + b;
            Console.Write("A két szám összege:{0} ", c);
            Console.ReadKey();
        }

        private static int szamotker(string szoveg)
        {
            int bekertszam;
            Console.Write(szoveg);
            bekertszam = Convert.ToInt32(Console.ReadLine());
            return bekertszam;
        }
    }
}
