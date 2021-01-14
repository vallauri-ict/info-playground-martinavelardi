using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP09_Scopa
{
    class Mazzo
    {
        private List<Carta> MazzoCarte = new List<Carta>();

        public Mazzo()
        {
            for (int i = 1; i <= 10; i++)
            {
                MazzoCarte.Add(new Carta(i, "Cuori"));
                MazzoCarte.Add(new Carta(i, "Quadri"));
                MazzoCarte.Add(new Carta(i, "Picche"));
                MazzoCarte.Add(new Carta(i, "Fiori"));
            }
        }
        public void Mescola()
        {

        }
        public void Estrai()
        {

        }
    }
}
