using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_classeAstratta01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStampaStudenti_Click(object sender, EventArgs e)
        {
            ElencoStudenti elStud = new ElencoStudenti();
            elStud.print(); // crea la stringa "stampa"
            MessageBox.Show(elStud.stampa);
        }
    }
}
