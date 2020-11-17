using System;
using System.Drawing;
using System.Windows.Forms;

namespace multiform02_formMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApri1_Click(object sender, EventArgs e)
        {
            // Form figlia interna a Form1
            Figlia1 f1 = new Figlia1();
            f1.Text = "Figlia 1";
            f1.MdiParent = this;    // imposto la form come parent
            f1.Size = new Size(210, 180);   // imposto la grandezza della form
            f1.StartPosition = FormStartPosition.Manual;    // posizionamento da codice. decido io dove metterla, non windows
            f1.Location = new Point(0, 50);  // imposto la posizione della form
            f1.Show();
        }

        private void btnApri2_Click(object sender, EventArgs e)
        {
            // Form figlia interna a Form1
            Figlia2 f2 = new Figlia2();
            f2.Text = "Figlia 2";
            f2.MdiParent = this;    // imposto la form come parent
            f2.Size = new Size(210, 180);   // imposto la grandezza della form
            f2.StartPosition = FormStartPosition.Manual;    // posizionamento da codice. decido io dove metterla, non windows
            f2.Location = new Point(215, 50);  // imposto la posizione della form
            f2.Show();
        }

        private void btnFAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " finestre");  // dice quante finestre figlie sono state aperte
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra '" + f.Text + "' aperta");    // mi dice il nome della finestra che è stata aperta
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire?";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Close();    // chiudo la form 1
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatuslbl.Text = "Hai premuto Apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatuslbl.Text = "Hai premuto Apri 2";
        }
    }
}
