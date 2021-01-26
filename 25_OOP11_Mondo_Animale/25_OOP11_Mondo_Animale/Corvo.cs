using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOP11_Mondo_Animale
{
    class Corvo:Bipede
    {
        public Corvo(String s) : base(s)
        {
            this.verso = "gracchia";
        }
        public override String chi_sei()
        {
            return "un corvo";
        }
        public override String si_muove()
        {
            return "volando";
        }
        public override String vive()
        {
            return "in un nido su un albero";
        }
    }
}
