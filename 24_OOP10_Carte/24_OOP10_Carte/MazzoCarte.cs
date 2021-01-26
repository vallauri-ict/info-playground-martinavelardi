using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24_OOP10_Carte;

namespace _24_OOP10_Carte
{
    class MazzoCarte:Carte
    {
        private int prog;
        List<Carte> lstMazzoCarte = new List<Carte>();
        public MazzoCarte()
        {

        }
        public void inserisciCarta()
        {

        }
        public List<Carte> dammiCarta()
        {
            return lstMazzoCarte;
        }
    }
}
