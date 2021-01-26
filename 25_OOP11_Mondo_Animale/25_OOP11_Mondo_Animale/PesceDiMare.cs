using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOP11_Mondo_Animale
{
    public abstract class PesceDiMare:AnimaleMarino
    {
        public PesceDiMare(String s) : base(s)
        {
            this.verso = "non fa versi";
        }
        public override String si_muove()
        {
            return "nuotando";
        }
    }
}
