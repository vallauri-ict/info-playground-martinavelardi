using System;
using System.Windows.Forms;

namespace multiform04_preparazione_verifica
{
    public partial class FormFiglia : Form
    {
        private TextBox txtPadre;
        private string txtValue;    // incapsula
        public FormFiglia()
        {
            InitializeComponent();
        }
        public FormFiglia(TextBox txtPadre)
        {
            InitializeComponent();
            this.txtPadre = txtPadre;
        }

        public string TxtValue
        {
            get => txtValue;
            set
            {
                if (value != "")
                {
                    txtValue = value;
                    txtFormFiglia.Text = txtValue;
                }
                else
                {
                    // genero una nuova eccezione
                    throw new Exception("Compilare il campo");
                }
            }
        }

        private void btnModificaFF_Click(object sender, EventArgs e)
        {
            txtPadre.Text = txtFormFiglia.Text;
        }
    }
}
