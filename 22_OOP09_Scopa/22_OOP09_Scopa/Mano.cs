using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP09_Scopa
{
    class Mano
    {
        List<Carta> ManoGiocatore = new List<Carta>();

        public Mano()
        {
            ManoGiocatore.Clear();
        }

        public List<Carta> Lettura()
        {
            return ManoGiocatore;
        }

        public Carta Gioca(int indice)
        {
            Carta giocata = ManoGiocatore[indice];
            ManoGiocatore.RemoveAt(indice);
            return giocata;
        }
    }
}
