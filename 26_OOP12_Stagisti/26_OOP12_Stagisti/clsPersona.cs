using System;

namespace _26_OOP12_Stagisti
{
    abstract class clsPersona
    {
        #region attributi
        private string nome;
        private string cognome;
        private string citta;

        protected string Nome
        {
            get => nome; set
            {
                if (value.Trim().Length >= 2) //trim toglie gli spazzi
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("nome non valida");
                }
            }
        }
        protected string Cognome
        {
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2) //trim toglie gli spazzi
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("Cognome non valida");
                }
            }
        }
        protected string Citta
        {
            get => citta; set
            {
                if (value.Trim().Length >= 2) //trim toglie gli spazzi
                {
                    citta = value;
                }
                else
                {
                    throw new Exception("Città non valida");
                }
            }

        }
        #endregion
        protected clsPersona(string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }
        public abstract string visualizza();
    }
}
