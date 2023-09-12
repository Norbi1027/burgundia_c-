using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace berek
{
    internal class Program
    {
        string bekertReszleg = "";
        static List <beker_class> adatok = new List <beker_class> ();
        static void Main(string[] args)
        {
            adatBeolvasas();
            feladat3();
            feladat4 ();
            feladat6();
            feladat7 ();
            Console.WriteLine("Program vége");
            Console.ReadKey();
        }

        private static void feladat7()
        {
            Console.WriteLine($"7. Feladat: Statisztika");
            adatok.GroupBy(x => x.Részleg1).ToList().ForEach(x => Console.WriteLine($"\t{x.Key} - {x.Count()} fő"));
        }

        public static void feladat6()
        {
            try
            {
                Console.Write("5. Feladat: Kérem a részleg nevét: ");
                string bekertReszleg = Console.ReadLine();
                int index = adatok.IndexOf(adatok.Where(x => x.Részleg1 == bekertReszleg).OrderByDescending(x => x.Bér1).First());
                Console.WriteLine("6. Feladat: A legtöbbet kereső dolgozó a megadott részlegen");
                Console.WriteLine($"\tNév: {adatok[index].Név1}");
                Console.WriteLine($"\tNem: {adatok[index].Neme1}");
                Console.WriteLine($"\tBelépés: {adatok[index].Belépés1}");
                Console.WriteLine($"\tBér: {adatok[index].Bér1:### ###} Forint");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("6. Feladat: A megadott részleg nem létezik a cégnél!");
            }
        }


        private static void feladat4()
        {
                Console.WriteLine($"{(double)adatok.Average(x => x.Bér1) / 1000:00.0} eFt");

        }

        private static void feladat3()
        {            
                Console.WriteLine("3.feladat");
                Console.WriteLine($"\t{adatok.Count}db dolgozó adatait tárolja.");        
        }

        private static void adatBeolvasas()
        {
            try 
            {
                using (StreamReader file = new StreamReader("berek2020.txt"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatok.Add(new beker_class(file.ReadLine()));

                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
