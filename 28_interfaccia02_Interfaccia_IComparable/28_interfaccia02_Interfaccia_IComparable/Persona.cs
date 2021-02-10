using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_interfaccia02_Interfaccia_IComparable
{
    class Persona:IComparable
    {
        private string nome;
        private string cognome;
        private string città;

        public Persona(string nome, string cognome, string città)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Città = città;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Città { get => città; set => città = value; }
        public int CompareTo(object obj)
        {
            if (obj==null)
            {
                return 1;   // un oggetto null è più piccolo di tutti
            }
            Persona p = obj as Persona; // faccio il casting
            return String.Compare(Cognome, p.Cognome, true);  // true è per il case sensitive
        }
        public override string ToString()
        {
            return Cognome + " " + Nome + " " + Città;
        }
    }
}
