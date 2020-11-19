using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Libro
        {
            public string titolo;
            public string autore;
        }
        public int i = 0;
        Dictionary<int, Libro> dizionarioLibri = new Dictionary<int, Libro>();
        // tabella di hash
        // usato quando devo fare delle ricerche rapide
        // da una chiave puoi tirare fuori altri dati, come quando fai le ricerche su un dizionario che cerchi una lettera e ti compaiono tante parole

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            dizionarioLibri.Add(i,l);
            i++;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            // le strutture si possono scorrere con un foreach perché implementano delle interfacce ("classe" in cui sono presenti solo le firme dei metodi) iCollection

            // stampa gli indici degli elementi presenti all'interno di dizionarioLibro
            foreach (var key in dizionarioLibri.Keys)
            {
                MessageBox.Show(key.ToString());
            }

            // stampa il titolo e l'autore dei libri che ho inserito
            foreach (Libro l in dizionarioLibri.Values)
            {
                MessageBox.Show($"{l.titolo} {l.autore}");
            }
        }
    }
}
