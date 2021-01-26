using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOP11_Mondo_Animale
{
    class Uomo:Bipede
    {
        public Uomo(String s) : base(s)
        {
            this.verso = "parla";
        }
        public override String chi_sei()
        {
            return "un homo sapiens";
        }
        public override String vive()
        {
            return "in condominio";
        }
    }
}
