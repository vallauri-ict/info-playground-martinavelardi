using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_classeAstratta01
{
    class ElencoStudenti : Report   // clicco sulla lampadina e faccio "implementa la classe astratta"
    {
        private List<Studente> lstStudenti = new List<Studente>();
        public string stampa = "";

        protected override void printBody()
        {
            foreach (var studente in lstStudenti)
            {
                stampa += studente.nomeCompleto() + "\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "FOOTER STAMPA STUDENTI\n";
        }

        protected override void printHeader()
        {
            stampa += "INTESTAZIONE STAMPA STUDENTI\n";
        }

        public ElencoStudenti()
        {
            lstStudenti.Add(new Studente("Sonia", "Botta"));
            lstStudenti.Add(new Studente("Lucrezia", "Carboni"));
        }
    }
}
