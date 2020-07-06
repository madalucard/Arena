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
        /// <param name="magicUtok"></param>
        public Mag(string meno, int zivot, int utok, int obrana, Kocka kocka, int mana, int magicUtok) : base(meno, zivot, utok, obrana, kocka)
        {
            this.mana = mana;
            this.maxMana = mana;
            this.magicUtok = magicUtok;
        }

        /// <summary>
        /// Vypocita nam celkovu vysku aj Magickeho utoku a zautoci na supera
        /// </summary>
        /// <param name="super"></param>
        public override void Utok(Bojovnik super)
        {
            int uder = 0;
            // Mana nieje plna
            if (mana < maxMana)
            {
                mana += 10;
                if (mana > maxMana)
                    mana = maxMana;
                uder = utok + kocka.Hod();
                NastavSpravu(string.Format("{0} utoci s uderem za {1}Hp", meno, uder));                
            } 
            else // magic attack
            {
                uder = magicUtok + kocka.Hod();
                NastavSpravu(String.Format("{0} pouzil magiu za {1}Hp", meno, uder));
                mana = 0;
            }
            super.BranSa(uder);
        }






    }
}
