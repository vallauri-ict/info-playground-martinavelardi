﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP09_Scopa
{
    class Carta
    {
        private int valore;
        private string seme;

        public Carta(int valore, string seme)
        {
            this.valore = valore;
            this.seme = seme;
        }

        public void Lettura(out int valore, out string seme)
        {
            valore = this.valore;
            seme = this.seme;
        }
    }
}
