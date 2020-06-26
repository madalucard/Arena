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


            Console.ReadLine();
        }
    }
}
