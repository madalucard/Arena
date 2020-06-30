using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Arena
{
    class Arena
    {   
        /// <summary>
        /// Instancia bojovnika1
        /// </summary>
        private Bojovnik bojovnik1;
        /// <summary>
        /// Instancia bojovnika2
        /// </summary>
        private Bojovnik bojovnik2;
        /// <summary>
        /// Instancia kocky
        /// </summary>
        private Kocka kocka;
        /// <summary>
        /// Konstruktor areny
        /// </summary>
        /// <param name="bojovnik1"></param>
        /// <param name="bojovnik2"></param>
        /// <param name="kocka"></param>
        public Arena(Bojovnik bojovnik1, Bojovnik bojovnik2, Kocka kocka)
        {
            this.bojovnik1 = bojovnik1;
            this.bojovnik2 = bojovnik2;
            this.kocka = kocka;
        }
        /// <summary>
        /// Vyskresli nam aktualne info o bojovnikoch
        /// </summary>
        private void Vykresli()
        {
            Console.Clear();
            Console.WriteLine("---------------Arena---------------\n");
            Console.WriteLine("Zdravie bojovnikov \n");
            Console.WriteLine("{0} {1}", bojovnik1, bojovnik1.GrafickyZivot());
            Console.WriteLine("{0} {1}", bojovnik2, bojovnik2.GrafickyZivot());
        }
        /// <summary>
        /// Vypise spravu s prestavkou 250ms
        /// </summary>
        /// <param name="sprava"></param>
        private void VypisSpravu(string sprava)
        {
            Console.WriteLine(sprava);
            Thread.Sleep(250);
        }

        public void Zapas()
        {
            Console.WriteLine("Vitajte v Arene!");
            Console.WriteLine("V zapase sa stretne {0} s {1}.", bojovnik1, bojovnik2);
            Console.WriteLine("Zapas moze zacat...");

            // Bojovy cyklus
            while (bojovnik1.Nazivo() && bojovnik2.Nazivo())
            {
                bojovnik1.Utok(bojovnik2);
                Vykresli();
                VypisSpravu(bojovnik1.VratPosleduSpravu()); // sprava o utoku
                VypisSpravu(bojovnik2.VratPosleduSpravu()); // sprava o obrane

                bojovnik2.Utok(bojovnik1);
                Vykresli();
                VypisSpravu(bojovnik2.VratPosleduSpravu()); // sprava o utoku
                VypisSpravu(bojovnik1.VratPosleduSpravu()); // sprava o obrane
                Console.WriteLine();
            }

        }





    }
}
