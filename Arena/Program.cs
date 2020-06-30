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
            Bojovnik bojovnik = new Bojovnik("Martin",100,20,10,desatStenna);
            Console.WriteLine("Bojovnik: " + bojovnik);  // test ToString();
            Console.WriteLine("Nazivo: " + bojovnik.Nazivo());  // test Nazivo();
            Console.WriteLine("Zivot: " + bojovnik.GrafickyZivot()); // test GrafickyZivot();
            Console.WriteLine();
            // vytvorenie supera
            Bojovnik super = new Bojovnik("Clone", 70, 17, 13, desatStenna);
            Console.WriteLine("Bojovnik: " + super);  // test ToString();
            Console.WriteLine("Nazivo: " + super.Nazivo());  // test Nazivo();
            Console.WriteLine("Zivot: " + super.GrafickyZivot()); // test GrafickyZivot();
            Console.WriteLine();
            // test utok na bojovnika
            super.Utok(bojovnik);
            Console.WriteLine("Zivot po utoku " + super.ToString() + " na " + bojovnik.ToString() + ": " + bojovnik.GrafickyZivot());



            Console.ReadLine();
        }
    }
}
