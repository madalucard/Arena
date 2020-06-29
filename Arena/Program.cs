using System;
using System.Dynamic;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            // Vytvorenie kociek
            Kocka sestStenna = new Kocka();
            Kocka desatStenna = new Kocka(10);
            /*
            // Hod 6stennou
            Console.WriteLine(sestStenna);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(sestStenna.Hod() + " ");
            }
            Console.WriteLine();
            // Hod 10stennou 
            Console.WriteLine(desatStenna);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(desatStenna.Hod() + " ");
            }
            */

            // vytvorenie bojovnika
            Bojovnik bojovnik1 = new Bojovnik("Martin",100,15,17,desatStenna);
            Console.WriteLine("Bojovnik: " + bojovnik1);  // test ToString();
            Console.WriteLine("Nazivo: " + bojovnik1.Nazivo());  // test Nazivo();
            Console.WriteLine("Zivot: " + bojovnik1.GrafickyZivot()); // test GrafickyZivot();



            Console.ReadLine();
        }
    }
}
