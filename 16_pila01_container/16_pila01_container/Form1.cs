using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_pila01_container
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Contenitore
        {
            public string codice;
            public double peso;
            public double tara;
        }

        // Dichiarazione pila
        Stack<Contenitore> pila = new Stack<Contenitore>();

        private void btnImpila_Click(object sender, EventArgs e)
        {
            if (txtCodice.Text!=""&&txtPeso.Text!=""&&txtTara.Text!="")
            {
                Contenitore c;
                c.codice = txtCodice.Text;
                c.peso = Convert.ToDouble(txtPeso.Text);
                c.tara = Convert.ToDouble(txtTara.Text);

                pila.Push(c);
                pulisciCampi();
            }
            else
            {
                MessageBox.Show("Campi mancanti");
            }
        }

        private void pulisciCampi()
        {
            txtCodice.Text = "";
            txtCodice.Focus();
            txtPeso.Text = "";
            txtTara.Text = "";
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            if (pila.Any())
            {
                MessageBox.Show($"Container\nCodice: {pila.Peek().codice}\nPeso: {pila.Peek().peso}\nTara: {pila.Peek().tara}");
                pila.Pop();
            }
            else
            {
                MessageBox.Show("Nessun container da rimuovere");
            }
        }
    }
}
