using System;

namespace _26_OOP12_Stagisti
{
    class clsStagista : clsAlunno
    {
        #region attributi
        private string azienda;
        private int ore;
        #endregion

        #region property
        // internal => lo posso usare all'interno del namespace
        internal string Azienda { get => azienda; set => azienda = value; }
        internal string Ore
        {
            get
            {
                return ore.ToString();
            }
            set
            {
                if (Convert.ToInt32(value) < 1)
                {
                    throw new Exception("Numero di ore non valido");
                }
                else ore = Convert.ToInt32(value);
            }
        }
        #endregion

        public clsStagista(string nome, string cognome, string citta, string classe, string sezione, string specializzazione, string azienda, string ore)
                   : base(nome, cognome, citta, classe, sezione, specializzazione)
        {
            Azienda = azienda;
            Ore = ore;
        }

        public override string visualizza()
        {
            return $"{base.visualizza()} {azienda} {ore}";
        }
    }
}
