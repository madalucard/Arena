using System;
using System.Collections.Generic;
using System.Text;

namespace Arena
{

    class Mag : Bojovnik
    {  
        /// <summary>
        /// Mana maga
        /// </summary>
        private int mana;
        /// <summary>
        /// Max mana maga
        /// </summary>
        private int maxMana;
        /// <summary>
        /// Magic utok maga
        /// </summary>
        private int magicUtok;

        /// <summary>
        /// Konstruktor maga
        /// </summary>
        /// <param name="meno"></param>
        /// <param name="zivot"></param>
        /// <param name="utok"></param>
        /// <param name="obrana"></param>
        /// <param name="kocka"></param>
        /// <param name="mana"></param>
        /// <param name="maxMana"></param>
        public Mag(string meno, int zivot, int utok, int obrana, Kocka kocka, int mana, int maxMana) : base(meno, zivot, utok, obrana, kocka)
        {
            this.mana = mana;
            this.maxMana = maxMana;
            this.magicUtok = magicUtok;
        }






    }
}
