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
            Console.WriteLine("Adja meg az első számot.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja mega második számot.");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("A két szám összege:{0} ", c);
            Console.ReadKey();
        }
    }
}
