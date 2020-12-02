namespace _17_ereditarietà01
{
    class Mostro
    {
        protected double punti;
        protected string verso;

        public Mostro()
        {
            punti = 25;
            verso = "grugnito";
        }
        public Mostro(int q)
        {
            this.punti = q;
        }
        public double Valore()
        {
            return punti;
        }
        public string Verso()
        {
            return verso;
        }
    }
}
