using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_classeAstratta01
{
    class Studente
    {
        private string nome;
        private string cognome;
        private DateTime dataNascita;

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get; set; } // è uguale a quello sopra

        public string nomeCompleto()
        {
            return Nome + " " + Cognome;
        }
    }
}
