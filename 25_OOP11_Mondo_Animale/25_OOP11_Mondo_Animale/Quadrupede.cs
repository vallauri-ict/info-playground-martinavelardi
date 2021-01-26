using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOP11_Mondo_Animale
{
    public abstract class Quadrupede:Animale
    {
        public Quadrupede(String s) : base(s)
        {

        }
        public override String si_muove()
        {
            return "avanzando su 4 zampe";
        }
    }
}
