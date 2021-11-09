using System;
using System.Collections.Generic;
using System.Text;

namespace Test_2021119 //GitHub LosLukynos
{
    internal class osoba
    {
        private int vlozeno;
        private string text;
        private int v;

        public string Jmeno { get; }
        public int Stav { get; }
        public int MaximalniStav { get; }
        public int Vlozeno { get => vlozeno; }


        public osoba(string jmeno, int maximalniStav)
        {
            Jmeno = jmeno;
            MaximalniStav = maximalniStav;
        }

        

        public int Vloz(int penize)
        {
            var mistoNaUctu = MaximalniStav - Vlozeno;

            if (mistoNaUctu > penize)
            {
                vlozeno += penize;
                return penize;
            }
            else
            {
                vlozeno += mistoNaUctu;
                return mistoNaUctu;
            }
        }

        public int Vyber(int penize)
        {
            if(penize > Vlozeno)
            {
                var aktualniStav = Vlozeno;
                vlozeno = 0;
                return aktualniStav;
            }
            else
            {
                vlozeno -= penize;
                return penize;
            }
        }
    }

    
}
