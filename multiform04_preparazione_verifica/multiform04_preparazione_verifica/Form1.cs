using System;
using System.Windows.Forms;

namespace multiform04_preparazione_verifica
{
    public partial class Form1 : Form
    {
        public TextBox txtModificato;
        public Form1()
        {
            InitializeComponent();
        }

        private void newSecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecondaria fs = new FormSecondaria(txtNome, txtEtà);
            fs.Text = "Form secondaria";
            fs.Show();
            toolStripStatusLbl.Text = "Form secondaria";
        }


        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Save";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Load";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEsci fe = new FormEsci();
            fe.Text = "Uscire?";
            toolStripStatusLbl.Text = "Form di uscita";
            if (fe.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }

        private void newFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia ff = new FormFiglia(txtModifica);
            ff.Text = "Form figlia";
            ff.Show();
            toolStripStatusLbl.Text = "Form figlia";
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInfo fi = new FormInfo();
            fi.Text = "Info";
            fi.Show();
            toolStripStatusLbl.Text = "Form informazioni";
        }

        private void newMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMDI f = new FormMDI();
            f.Text = "Form MDI";
            f.Show();
            toolStripStatusLbl.Text = "Form MDI";
        }
    }
}
