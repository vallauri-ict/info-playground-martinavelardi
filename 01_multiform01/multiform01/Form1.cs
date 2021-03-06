﻿using System;
using System.Windows.Forms;

namespace multiform01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // richiamo il costruttore Form2 che carica tutti i componenti
            f2.Text = "Form2 aperta da Design";
            f2.Show();  // visualizzo la form

            Form2 f2b = new Form2(10); // richiamo il costruttore Form2 che carica tutti i componenti
            f2b.Text = "Form2 aperta da Design con parametro";
            f2b.Show();  // visualizzo la form
        }

        private void btnForm2b_Click(object sender, EventArgs e)
        {
            // creo una form dinamica di visual studio
            Form f2b = new Form();
            f2b.Text = "Aperta form dinamica";
            f2b.Show();
        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(txtPassata); // richiamo il costruttore Form2 che carica tutti i componenti
            f2b.Text = "Form2 con passaggio di TextBox";
            f2b.Show();  // visualizzo la form
        }

        private void btnFormModale_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            if (fm.ShowDialog() == DialogResult.OK) // ferma il codice finché non viene chiusa
            {
                txtNomeFM.Text = fm.nome;
                txtEtaFM.Text = fm.eta;
                MessageBox.Show("Hai premuto OK!");
            }
            else
            {
                txtNomeFM.Text = "";
                txtEtaFM.Text = "";
                MessageBox.Show("Hai premuto annulla!");
            }
        }
    }
}
