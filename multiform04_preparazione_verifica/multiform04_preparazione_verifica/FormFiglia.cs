using System;
using System.Windows.Forms;

namespace multiform04_preparazione_verifica
{
    public partial class FormFiglia : Form
    {
        public TextBox txtModifica;
        public FormFiglia()
        {
            InitializeComponent();
        }
        public FormFiglia(TextBox txtModifica)
        {
            InitializeComponent();
            this.txtModifica = txtModifica;
        }
        private void btnModificaFF_Click(object sender, EventArgs e)
        {
            txtModifica.Text = txtFormFiglia.Text;
        }
    }
}
