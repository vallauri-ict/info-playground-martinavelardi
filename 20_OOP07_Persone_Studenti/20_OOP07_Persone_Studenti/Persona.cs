namespace _20_OOP07_Persone_Studenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;

        public void SetAttributes(string nome, string cognome, string sesso, int eta)
        {
            if (nome != "" && cognome != "" && sesso != "" && eta != 0)
            {
                this.nome = nome;
                this.cognome = cognome;
                this.sesso = sesso;
                this.eta = eta;
            }
        }
        public string GetNome()
        {
            return this.nome;
        }
        public string GetCognome()
        {
            return this.cognome;
        }
        public string GetSesso()
        {
            return this.sesso;
        }
        public int GetEta()
        {
            return this.eta;
        }
    }
}
