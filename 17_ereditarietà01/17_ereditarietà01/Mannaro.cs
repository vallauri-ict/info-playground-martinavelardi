namespace _17_ereditarietà01
{
    class Mannaro : Mostro
    {
        protected bool mutato;
        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }
        public double Valore()
        {
            if (mutato)
            {
                return 2 * base.Valore();
            }
            else
            {
                return base.Valore();
            }
        }
        public string Verso()
        {
            if (mutato)
            {
                return verso;
            }
            else
            {
                return base.verso;
            }
        }
        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
