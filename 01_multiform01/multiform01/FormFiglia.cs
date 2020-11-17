using System;
using System.Windows.Forms;

namespace multiform01
{
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void btnFigliaDiChi_Click(object sender, EventArgs e)
        {
            if (Owner != null)    // Owner contiene chi è il padre
            {
                MessageBox.Show("Form figlia di " + Owner.Text);
            }
        }
    }
}
