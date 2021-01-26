using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOP11_Mondo_Animale
{
    class Tonno:PesceDiMare
    {
        public Tonno(String s) : base(s)
        {
        }
        public override String chi_sei()
        {
            return "un tonno";
        }
    }
}
