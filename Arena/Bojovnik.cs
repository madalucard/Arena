using System;
using System.Collections.Generic;
using System.Text;

namespace Arena
{
    class Bojovnik
    {
        #region atributy
        /// <summary>
        /// Meno bojovnika
        /// </summary>
        protected string meno;
        /// <summary>
        /// Max života bojovnika
        /// </summary>
        protected int maxZivot;
        /// <summary>
        /// Aktualne životy bojovnika
        /// </summary>
        protected int zivot;
        /// <summary>
        /// Utok bojovnika v Hp
        /// </summary>
        protected int utok;
        /// <summary>
        /// Obranna bojovnika v Hp
        /// </summary>
        protected int obrana;
        /// <summary>
        /// Instancia hracej kocky
        /// </summary>
        protected Kocka kocka;
        private string sprava;
        #endregion

        #region metody
        public Bojovnik() 
        {
        }
        /// <summary>
        /// Konstruktor bojvnika
        /// </summary>
        /// <param name="meno"></param>
        /// <param name="zivot"></param>
        /// <param name="utok"></param>
        /// <param name="obrana"></param>
        /// <param name="kocka"></param>
        public Bojovnik(string meno, int zivot, int utok, int obrana, Kocka kocka) 
        {
            this.meno = meno;
            this.maxZivot = zivot;
            this.zivot = zivot;
            this.utok = utok;
            this.obrana = obrana;
            this.kocka = kocka; 
        }
        /// <summary>
        /// Vrati meno bojovnika v stringu
        /// </summary>
        /// <returns>Meno</returns>
        public override string ToString()
        {
            return meno;
        }
        /// <summary>
        /// Vrati nam bool hodnotu bojovnikovho stavu
        /// </summary>
        /// <returns>True/False</returns>
        public bool Nazivo()
        {
            return (zivot > 0);
        }
        /// <summary>
        /// Vrati nam zivot v grafickom prevedeni 20 dielov
        /// </summary>
        /// <returns>Graficky zivot</returns>
        public string GrafickyZivot()
        {
            string s = "[";
            int celkom = 20;
            double pocet = Math.Round(((double)zivot / maxZivot) * celkom);
            if ((pocet == 0) && (Nazivo()))
                pocet = 1;
            for (int i = 0; i < pocet; i++)
                s += "#";
            s = s.PadRight(celkom + 1);
            s += "]";            
            return s;
        }
        /// <summary>
        /// Vypocita nam realne poskodenie pri utoku
        /// </summary>
        /// <param name="uder"></param>
        public void BranSa(int uder)
        {
            int zranenie = uder - (obrana + kocka.Hod());
            if (zranenie > 0)
            {
                zivot -= zranenie;
                sprava = String.Format("{0} utrpel poskodenie {1} hp.",meno, zranenie);
                if (zivot <= 0)
                    zivot = 0;
            }
        }
        /// <summary>
        /// Vypocita nam celkovu vysku utoku a zautoci na supera
        /// </summary>
        /// <param name="super"></param>
        public virtual void Utok(Bojovnik super)
        {
            int uder = utok + kocka.Hod();
            NastavSpravu(String.Format("{0} utoci s uderom za {1} hp", meno, uder));
            super.BranSa(uder);
        }
        /// <summary>
        /// Nastavi na, spravu
        /// </summary>
        /// <param name="sprava"></param>
        protected void NastavSpravu(string sprava)
        {
            this.sprava = sprava;
        }
        /// <summary>
        /// Vrati nam poslednu spravu
        /// </summary>
        /// <returns>String sprava</returns>
        public string VratPosleduSpravu()
        {
            return sprava;
        }


        #endregion


    }
}
