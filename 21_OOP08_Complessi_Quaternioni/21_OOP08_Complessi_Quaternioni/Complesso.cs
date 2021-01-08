using System;

namespace _21_OOP08_Complessi_Quaternoni
{
    class Complesso
    {
        private double reale = 0;
        private double immaginario = 0;

        public Complesso() : this(1)    // questo
        {
        }
        public Complesso(double immaginario) : this(0, immaginario) // richiama questo
        {
        }
        public Complesso(double reale, double immaginario)  // che richiama questo
        {
            Immaginario = immaginario;
            Reale = reale;
        }
        public double Reale { get => reale; set => reale = value; }
        public double Immaginario { get => immaginario; set => immaginario = value; }
        public double Modulo()
        {
            double somma = Math.Pow(Reale, 2) + Math.Pow(Immaginario, 2);
            return Math.Sqrt(somma);
        }
        public void Coniugato()
        {
            immaginario = -immaginario;
        }
    }
}
