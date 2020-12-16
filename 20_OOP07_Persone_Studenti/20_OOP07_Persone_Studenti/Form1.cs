using System;
using System.Windows.Forms;

namespace _20_OOP07_Persone_Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            dgvVoti.Rows.Add(txtNome.Text,txtCognome.Text,txtSesso.Text,txtEtà.Text,txtVoto.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvVoti.ColumnCount = 5;
            dgvVoti.RowHeadersVisible = false;
            dgvVoti.Columns[0].Name = "Nome";
            dgvVoti.Columns[1].Name = "Cognome";
            dgvVoti.Columns[2].Name = "Sesso";
            dgvVoti.Columns[3].Name = "Età";
            dgvVoti.Columns[4].Name = "Media Voti";
        }
    }
}
