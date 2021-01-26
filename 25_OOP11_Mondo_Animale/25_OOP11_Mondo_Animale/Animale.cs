using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_OOP11_Mondo_Animale
{
    public abstract class Animale
    {
        private String nome;
        protected String verso;

        public Animale(String s)
        {
            nome = s;
        }
        public abstract String si_muove();
        public abstract String vive();
        public abstract String chi_sei();
        public void mostra()
        {
            MessageBox.Show($"{nome}, {chi_sei()}, {verso}, si muove {si_muove()}, e vive {vive()}");
        }
    }
}
