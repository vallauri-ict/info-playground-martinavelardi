using System;
using System.Windows.Forms;

namespace multiform03_es01_con_formMDI
{
    public partial class FormModale : Form
    {
        public string nome = "";
        public string eta = "";

        public FormModale()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nome = "";
            eta = "";
        }
    }
}
