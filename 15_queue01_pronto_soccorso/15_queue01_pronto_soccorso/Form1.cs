using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _15_queue01_pronto_soccorso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Paziente
        {
            public string nome;
            public int età;
            public string colore;
            public double temperatura;
        }

        // Dichiarazione code
        Queue<Paziente> rosso = new Queue<Paziente>();
        Queue<Paziente> giallo = new Queue<Paziente>();
        Queue<Paziente> verde = new Queue<Paziente>();
        Queue<Paziente> bianco = new Queue<Paziente>();

        // Temperatura
        List<double> temp = new List<double>();

        private void btnAggiungiPaziente_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEtà.Text != "" && txtColore.Text != "" && label5.Text != "")
            {
                Paziente p;
                p.nome = txtNome.Text;
                p.età = Convert.ToInt32(txtEtà.Text);
                p.colore = txtColore.Text;
                p.temperatura = Double.Parse(txtTemperatura.Text);
                temp.Add(Double.Parse(txtTemperatura.Text));

                switch (txtColore.Text)
                {
                    case "rosso":
                        rosso.Enqueue(p);
                        break;
                    case "giallo":
                        giallo.Enqueue(p);
                        break;
                    case "verde":
                        verde.Enqueue(p);
                        break;
                    case "bianco":
                        bianco.Enqueue(p);
                        break;
                }

                pulisciCampi();
            }
            else
            {
                MessageBox.Show("Campi mancanti");
            }
        }

        private void pulisciCampi()
        {
            txtNome.Text = "";
            txtNome.Focus();
            txtEtà.Text = "";
            txtColore.Text = "";
            txtTemperatura.Text = "";
        }

        private void btnProssimoPaziente_Click(object sender, EventArgs e)
        {
            if (rosso.Any())
            {
                stampaPaziente(rosso.Peek());
                rosso.Dequeue();
            }
            else if (giallo.Any())
            {
                stampaPaziente(giallo.Peek());
                giallo.Dequeue();
            }
            else if (verde.Any())
            {
                stampaPaziente(verde.Peek());
                verde.Dequeue();
            }
            else if (bianco.Any())
            {
                stampaPaziente(bianco.Peek());
                bianco.Dequeue();
            }
            else
            {
                lblNome.Text = "Nome:";
                lblEtà.Text = "Età:";
                lblColore.Text = "Colore:";
                lblTemperatura.Text = "Temperatura";

                MessageBox.Show("Non ci sono pazienti in coda");
            }
        }

        private void stampaPaziente(Paziente paziente)
        {
            lblNome.Text = $"Nome: {paziente.nome }";
            lblEtà.Text = $"Età: {paziente.età}";
            lblColore.Text = $"Colore: {paziente.colore}";
            lblTemperatura.Text = $"Temperatura: {paziente.temperatura}";
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            double max = 0;
            double min = 1000;

            for (int i = 0; i < temp.Count(); i++)
            {
                if (temp[i] > max)
                {
                    max = temp[i];
                }
                else if (temp[i] < min)
                {
                    min = temp[i];
                }
            }

            MessageBox.Show("Temperatura massima: " + max.ToString() + "\nTemperatura minima: " + min.ToString());
        }
    }
}
