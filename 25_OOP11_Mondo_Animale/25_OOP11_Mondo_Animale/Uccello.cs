using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOP11_Mondo_Animale
{
    class Uccello:Animale
    {
        public Uccello(String s) : base(s)
        {
            this.verso = "cinguetta";
        }
        public override String vive()
        {
            return "in un nido su un albero";
        }

        public override String chi_sei()
        {
            return "un uccello";
        }

        public override string si_muove()
        {
            return "volando";
        }
    }
}
