using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOP11_Mondo_Animale
{
    public class Cavallo:Quadrupede
    {
        public Cavallo(String s) : base(s)
        {
            this.verso = "nitrisce";
        }
        public override String chi_sei()
        {
            return "un cavallo";
        }
        public override String vive()
        {
            return "sulla terraferma";
        }

    }
}
