using System;
using System.Collections.Generic;
using System.Text;

namespace Arena
{
    /// <summary>
    /// Trieda reprezentuje hraciu kocku
    /// </summary>
    class Kocka
    {
        /// <summary>
        /// Generator nahodnych cisel
        /// </summary>
        private Random rand;
        /// <summary>
        /// Pocet stien kocky
        /// </summary>
        private int pocetStien;
        /// <summary>
        /// Bezprametricky konstruktor kocky s defaultym poctom stien 6
        /// </summary>
        public Kocka(){
            pocetStien = 6;
            rand = new Random();
        }
        /// <summary>
        /// Konstruktor kockz s nastavitelnym poctom stien
        /// </summary>
        /// <param name="pocetSten"></param>
        public Kocka(int pocetSten) {
            this.pocetStien = pocetSten;
            rand = new Random();
        }
        /// <summary>
        /// Vrati pocet stien kocky
        /// </summary>
        /// <returns>Pocet stien kocky</returns>
        public int GetPocetStien() {
            return pocetStien;
        }
        /// <summary>
        /// Vykona hod kockou
        /// </summary>
        /// <returns>Cislo od 1 do poctu stien</returns>
        public int Hod()
        {
            return rand.Next(1, pocetStien + 1);
        }
        /// <summary>
        /// Vracia textovu reprezentaciu kocky
        /// </summary>
        /// <returns>Textova reprezentacia kocky</returns>
        public override string ToString()
        {
            return String.Format("Kocka s {0} stenami", pocetStien);
        }
    }
}
