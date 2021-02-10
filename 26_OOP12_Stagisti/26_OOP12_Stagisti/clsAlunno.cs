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
        protected string Matricola => matricola;
        public string Sezione { get => sezione; set => sezione = value; }
        public string Specializzazione { get => specializzazione; set => specializzazione = value; }

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
