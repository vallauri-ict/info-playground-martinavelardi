﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            f2.Show();  // visualizzo la form
        }

        private void btnForm2b_Click(object sender, EventArgs e)
        {
            // creo una form dinamica di visual studio
            Form f2b = new Form();
            f2b.Text = "Aperta form dinamica";
            f2b.Show();
        }
    }
}
