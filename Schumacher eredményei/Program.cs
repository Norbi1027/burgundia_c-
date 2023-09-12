using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Schumacher_eredményei
{
    internal class Program
    {
        static List <Class1> adatok = new List <Class1> ();
        static void Main(string[] args)
        {
            adatokBeolvasasa();
            feladatok3();
            feladatok4 ();
            feladatok5();
            Console.WriteLine("program vége!");
            Console.ReadKey();
        }

        private static void feladatok5()
        {
            Console.WriteLine("5.feladat hibastatisztika");
            foreach (var item in adatok.FindAll(z => z.Position==0).GroupBy(a => a.Status).Select(b => new {ok=b.Key, db = b.Count()}))
            {
                if (item.db>2)
                {
                    Console.WriteLine($"\t{item.ok} : {item.db}");
                }
            }
        }

        private static void feladatok4()
        {
            Console.WriteLine("4.feladat: magyar nagydíj helyezései");
            foreach (var item in adatok.FindAll(a => a.Grandprix.Equals("Hungarian Grand Prix")&& a.Position>0))
                Console.WriteLine($"\t{item.Date.ToShortDateString()} : {item.Position}.hely");
            {

            }
        }

        private static void feladatok3()
        {
            Console.WriteLine("3.feladat");
            Console.WriteLine(  $"\t{adatok.Count} sort olvasott be.");
        }

        private static void adatokBeolvasasa()
        {
            try
            {
                using (StreamReader file = new StreamReader("schumacher.csv"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatok.Add(new Class1 (file.ReadLine()));

                    }
                }
              

            }
            catch(IOException ex)  
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
