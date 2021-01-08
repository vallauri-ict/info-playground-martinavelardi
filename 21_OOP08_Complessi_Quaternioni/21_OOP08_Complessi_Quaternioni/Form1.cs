using _21_OOP08_Complessi_Quaternoni;
using System;
using System.Windows.Forms;

namespace _21_OOP08_Complessi_Quaternioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComplesso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReale.Text == "" && txtImmaginario.Text != "")
                {
                    Complesso complesso = new Complesso(Convert.ToDouble(txtImmaginario.Text));
                    MessageBox.Show(complesso.Modulo().ToString());
                }
                else if (txtReale.Text != "" && txtImmaginario.Text != "")
                {
                    Complesso complesso = new Complesso(Convert.ToDouble(txtReale.Text), Convert.ToDouble(txtImmaginario.Text));
                    MessageBox.Show(complesso.Modulo().ToString());
                }
                else
                {
                    Complesso complesso = new Complesso();
                    MessageBox.Show(complesso.Modulo().ToString());
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Parametro mancante");
            }
        }

        private void btnQuaternione_Click(object sender, EventArgs e)
        {
            Quaternione quaternione = new Quaternione(Convert.ToDouble(txtReale.Text == "" ? "0" : txtReale.Text), 
                                                      Convert.ToDouble(txtImmaginario.Text == "" ? "0" : txtImmaginario.Text),
                                                      Convert.ToDouble(txtImmaginarioC.Text == "" ? "0" : txtImmaginarioC.Text), 
                                                      Convert.ToDouble(txtImmaginarioD.Text == "" ? "0" : txtImmaginarioD.Text));
            MessageBox.Show(quaternione.Modulo().ToString());
        }
    }
}
