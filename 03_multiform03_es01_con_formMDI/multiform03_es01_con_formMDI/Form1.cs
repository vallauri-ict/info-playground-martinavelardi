using System;
using System.Drawing;
using System.Windows.Forms;

namespace multiform03_es01_con_formMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form aperta da Design";
            f2.MdiParent = this;
            f2.Size = new Size(200, 200);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(0, 150);
            f2.Show();

            Form2 f2b = new Form2(10);
            f2b.Text = "Form aperta da Design con parametro";
            f2b.MdiParent = this;
            f2b.Size = new Size(200, 200);
            f2b.StartPosition = FormStartPosition.Manual;
            f2b.Location = new Point(0, 370);
            f2b.Show();
        }

        private void btnApriF2b_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Aperta form dinamica";
            f2b.MdiParent = this;
            f2b.Size = new Size(200, 200);
            f2b.StartPosition = FormStartPosition.Manual;
            f2b.Location = new Point(250, 150);
            f2b.Show();
        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtPassata);
            f2.Text = "Form2 con passaggio di textbox";
            f2.MdiParent = this;
            f2.Size = new Size(200, 200);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(500, 150);
            f2.Show();
        }

        private void btnFormModale_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                txtNomeFM.Text = fm.nome;
                txtEtaFM.Text = fm.eta;
                MessageBox.Show("Hai premuto OK!");
            }
            else
            {
                txtNomeFM.Text = "";
                txtEtaFM.Text = "";
                MessageBox.Show("Hai premuto CANCEL!");
            }
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hai premuto Apri form 2";
        }

        private void apriForm2bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hai premuto Apri form 2b";
        }

        private void passaATxtForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hai premuto Passa txt a form 2";
        }

        private void apriFormmodaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hai premuto Apri form modale";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModalEsci fm = new FormModalEsci();
            fm.Text = "Uscire?";
            if (fm.ShowDialog()==DialogResult.OK)
            {
                Close();
            }
        }
    }
}
