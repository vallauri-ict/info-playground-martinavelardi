using System;
using System.Numerics;

namespace _21_OOP08_Complessi_Quaternoni
{
    class Complesso
    {
        private double reale=0;
        private double immaginario=0;

        public Complesso():this(1)
        {
        }
        public Complesso(double immaginario):this(1,immaginario)
        {
        }
        public Complesso(double reale, double immaginario)
        {
            Immaginario = immaginario;
            Reale = reale;
        }
        public double Reale { get => reale; set => reale = value; }
        public double Immaginario { get => immaginario; set => immaginario = value; }
        public double Modulo(double reale, double immaginario)
        {
            double somma = Math.Pow(Reale, 2) + Math.Pow(Immaginario, 2);
            return Math.Sqrt(somma);
        }
        public void Coniugato(double immaginario)
        {
            Complex.Conjugate(immaginario);
        }
    }
}
