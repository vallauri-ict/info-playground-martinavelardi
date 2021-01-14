using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP09_Scopa
{
    class Giocatore : Mano
    {
        private string nome;
        private Mano mano;
        List<Carta> Prese = new List<Carta>();
    }
}
