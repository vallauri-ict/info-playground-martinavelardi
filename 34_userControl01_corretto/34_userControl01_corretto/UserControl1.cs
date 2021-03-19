using System;
using System.Windows.Forms;

namespace _34_userControl01_corretto
{
    public partial class UserControl1 : UserControl
    {
        private bool numero = false;    // Se true la txt accetta solo numeri
        private string testo;   // Testo della txt
        private int cifreDecimali = 0;  // Contiene il numero di cifre decimali dopo la virgola

        public UserControl1()
        {
            InitializeComponent();
        }

        public bool Numero { get { return numero; } set { numero = value; } }
        public string Testo { get => testo = txtTesto.Text; set { testo = value; txtTesto.Text = testo; } }
        public int CifreDecimali { get => cifreDecimali; set { cifreDecimali = value; reimpostaTesto(); } }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (numero)
            {
                if (!char.IsDigit(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void OnLeave(object sender,EventArgs e)
        {
            reimpostaTesto();
        }
        private void reimpostaTesto()
        {
            if (numero && testo != "")
            {
                try
                {
                    if (contaVirgola(txtTesto.Text) > 1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }
                    // Controllo dei decimali
                    double numero = Math.Round(Convert.ToDouble(testo), CifreDecimali);
                    Testo = numero.ToString();

                    // Gestione degli 00 dopo la virgola in caso di numero intero
                }
                catch (Exception)
                {
                    throw new Exception("Valore non valido");
                }
            }
        }

        private int contaVirgola(string t)
        {
            int count = 0;
            for (int i = 0; i < t.Length; i++)
            {
                char c = Convert.ToChar(t.Substring(i, 1));
                if (c == ',')
                {
                    count++;
                }
            }
            return count;
        }
        public void pulisci()
        {
            Testo = "";
        }
    }
}
