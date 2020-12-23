using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP08_Complessi_Quaternioni
{
    class Quaternione
    {
        private double j;
        private double k;

        public double J { get => j; set => j = value; }
        public double K { get => k; set => k = value; }

        public Quaternione()
        {
        }

        public Quaternione(double immaginario):this()
        {
            
        }
    }
}
