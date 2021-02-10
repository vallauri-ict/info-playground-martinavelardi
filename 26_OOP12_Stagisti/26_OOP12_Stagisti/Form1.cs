using System;
using System.Windows.Forms;

namespace _26_OOP12_Stagisti
{
    public partial class Form1 : Form
    {
        clsElenco elencoStudenti;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new clsElenco();
        }
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            clsAlunno stu;
            if (txtOreStage.Text.Trim() == "")
            {
                stu = new clsAlunno(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(),
                    cmbSpecializzazione.SelectedItem.ToString());
            }
            else
            {
                stu = new clsStagista(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(),
                    cmbSpecializzazione.SelectedItem.ToString(), cmbAzienda.SelectedItem.ToString(), txtOreStage.Text);
            }
            elencoStudenti.inserisci(stu);
            elencoStudenti.visualizzaDgv(dgvStudenti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
        }

        private void btnRicercaAzienda_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedItem.ToString();
            int ore = elencoStudenti.oreAzienda(azienda);
            if (ore != 0)
            {
                MessageBox.Show("Gli stagisti hanno effettuato " + ore + " in " + azienda, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Non è stata effettuata alcuna ora in " + azienda, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPosizione.Text == "")
                {
                    elencoStudenti.cancella();
                }
                else
                {
                    elencoStudenti.cancella(Convert.ToInt32(txtPosizione.Text));
                }
                MessageBox.Show("Cancellazione effettuata");
                elencoStudenti.visualizzaDgv(dgvStudenti);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
