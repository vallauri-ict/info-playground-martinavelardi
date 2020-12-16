using System;
using System.Numerics;

namespace _21_OOP08_Complessi_Quaternoni
{
    class Complesso
    {
        private double reale;
        private double immaginario;

        public Complesso()
        {

        }
        public Complesso(double reale)
        {
            this.reale = reale;
        }
        public Complesso(double reale, double immaginario)
        {
            this.reale = reale;
            this.immaginario = immaginario;
        }
        public double GetReale()
        {
            return this.reale;
        }
        public double GetImmaginario()
        {
            return this.immaginario;
        }
        public double Modulo(double reale, double immaginario)
        {
            return Math.Sqrt((reale * reale) + (2 * reale * immaginario) + (immaginario * immaginario));
        }
        public void Coniugato(double immaginario)
        {
            Complex.Conjugate(immaginario);
        }
    }
}
