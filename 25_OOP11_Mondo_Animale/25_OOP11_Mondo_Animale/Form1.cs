using System;
using System.Windows.Forms;

namespace _25_OOP11_Mondo_Animale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // AnimaleMarino p = new AnimaleMarino("x");
        // ERRATO: classe astratta!
        private void btnCavallo_Click(object sender, EventArgs e)
        {
            Cavallo c = new Cavallo("Furia del West");
            c.mostra();
        }

        private void btnUomo_Click(object sender, EventArgs e)
        {
            Uomo h = new Uomo("Johnny");
            h.mostra();
        }

        private void btnCorvo_Click(object sender, EventArgs e)
        {
            Corvo w = new Corvo("Il corvo dell'uva");
            w.mostra();
        }

        private void btnTonno_Click(object sender, EventArgs e)
        {
            Tonno t = new Tonno("Palmera");
            t.mostra();
        }

        private void btnUccello_Click(object sender, EventArgs e)
        {
            Uccello u = new Uccello("Gabbiano");
            u.mostra();
        }

        private void btnPinguino_Click(object sender, EventArgs e)
        {
            Pinguino p = new Pinguino("Tweety");
            p.mostra();
        }
    }
}
