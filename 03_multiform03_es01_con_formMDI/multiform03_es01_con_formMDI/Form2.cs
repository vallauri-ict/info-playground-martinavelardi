using System;
using System.Windows.Forms;

namespace multiform03_es01_con_formMDI
{
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt1;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }
        public Form2(TextBox txt1)
        {
            InitializeComponent();
            this.txt1 = txt1;
        }

        private void btnLeggiValore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore = " + n);
        }

        private void btnInviaF1_Click(object sender, EventArgs e)
        {
            txt1.Text = txtForm2.Text;
        }

        private void btnFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();
            this.AddOwnedForm(f);
            f.Text = "Form figlia";
            f.Show();
        }
    }
}
