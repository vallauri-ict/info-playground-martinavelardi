using System;
using System.Windows.Forms;

namespace multiform04_preparazione_verifica
{
    public partial class FormSecondaria : Form
    {
        public TextBox txtNome2;
        public TextBox txtEtà2;

        public FormSecondaria()
        {
            InitializeComponent();
        }
        public FormSecondaria(TextBox txtNome2, TextBox txtEtà2)
        {
            InitializeComponent();
            this.txtNome2 = txtNome2;
            this.txtEtà2 = txtEtà2;
        }

        private void btnOkFS_Click(object sender, EventArgs e)
        {
            txtNome2.Text = txtNomeFS.Text;
            txtEtà2.Text = txtEtàFS.Text;
            MessageBox.Show("Nome: " + txtNome2.Text + "\nEtà: " + txtEtà2.Text);
        }

        private void btnCancelFS_Click(object sender, EventArgs e)
        {
            txtNome2.Text = "";
            txtEtà2.Text = "";
            MessageBox.Show("Operazione annullata");
        }
    }
}
