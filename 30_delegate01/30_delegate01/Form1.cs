using System;
using System.Windows.Forms;

namespace _30_delegate01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Dichiarazione del delegate che accetta 2 parametri interi e restituisce un valore intero
        public delegate int Operazione(int a, int b);

        // Dichiaro le 3 funzioni che utilizzerò con il delegate
        public int Somma(int x, int y)
        {
            return x + y;
        }
        public int Sottrazione(int x, int y)
        {
            return x - y;
        }
        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            // PRIMO METODO per usare un delegate
            // Istanzio il delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma);  // Somma è la "funzione" puntata dal delegate

            // Richiamo il delegate che eseguirà la funzione Somma
            MessageBox.Show("Somma = " + op(10, 15));
        }

        private void btnProdotto_Click(object sender, EventArgs e)
        {
            // SECONDO METODO istanzio il delegate
            Operazione op = Prodotto;

            // Richiamo il delegate
            MessageBox.Show("Prodotto = " + op(10, 15));
        }
    }
}
