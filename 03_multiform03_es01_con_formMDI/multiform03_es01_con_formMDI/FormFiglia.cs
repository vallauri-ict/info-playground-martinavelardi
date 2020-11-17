using System;
using System.Windows.Forms;

namespace multiform03_es01_con_formMDI
{
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void btnFigliaDiChi_Click(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                MessageBox.Show("Form figlia di: " + Owner.Text);
            }
        }
    }
}
