using System;

namespace _26_OOP12_Stagisti
{
    class clsAlunno : clsPersona
    {
        #region attributi
        protected static int progressivo = 0;
        private readonly string matricola;
        private string classe;
        private string sezione;
        private string specializzazione;
        #endregion
        public string Classe { get => classe; set => classe = value; }
        public string Sezione { get => Sezione; set => Sezione = value; }

        protected string Matricola => matricola;
        public string Specializzazione { get => Specializzazione1; set => Specializzazione1 = value; }
        public string Specializzazione1 { get => specializzazione; set => specializzazione = value; }

        public clsAlunno(string nome, string cognome, string citta, string classe, string sezione, string specializzazione) : base(nome, cognome, citta)
        {
            Classe = classe;
            Sezione = sezione;
            Specializzazione = specializzazione;
            progressivo++;
            matricola = "A" + progressivo.ToString().PadLeft(5, '0');
        }
        public override string visualizza()
        {
            return $"{Matricola} {Nome} {Cognome} {Citta} {Classe} {Sezione} {Specializzazione}";
        }
    }
}
