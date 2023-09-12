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
        static List <beker_class> adatok = new List <beker_class> ();
        static void Main(string[] args)
        {
            adatBeolvasas();
            feladat3();
            Console.WriteLine("Program vége");
            Console.ReadKey();
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
