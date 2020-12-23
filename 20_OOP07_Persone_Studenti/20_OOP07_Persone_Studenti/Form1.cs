using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _20_OOP07_Persone_Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Studente> lstStudenti = new List<Studente>();
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s.SetAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEtà.Text));
            lstStudenti.Add(s);
            listStudenti.Items.Add(s.GetCognome());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string cognome = listStudenti.SelectedItems[0].Text;
            foreach (Studente i in lstStudenti)
            {
                if (i.GetCognome()== listStudenti.SelectedItems[0].Text)
                {
                    i.voti.Add(Convert.ToInt32(txtVoto.Text));
                }
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstStudenti.Find(stud=> stud.GetCognome()==listStudenti.SelectedItems[0].Text);
            MessageBox.Show($"La media dello studente {s.GetCognome()} {s.GetNome()} è: {s.Media()}");
        }
    }
}
