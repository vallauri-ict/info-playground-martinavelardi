
namespace _34_userControl01_Utilizzo_UserControl
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new _34_userControl01_corretto.UserControl1();
            this.chkSoloNumeri = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.CifreDecimali = 0;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Numero = false;
            this.userControl11.Size = new System.Drawing.Size(107, 26);
            this.userControl11.TabIndex = 0;
            this.userControl11.Testo = "";
            // 
            // chkSoloNumeri
            // 
            this.chkSoloNumeri.AutoSize = true;
            this.chkSoloNumeri.Location = new System.Drawing.Point(13, 87);
            this.chkSoloNumeri.Name = "chkSoloNumeri";
            this.chkSoloNumeri.Size = new System.Drawing.Size(119, 17);
            this.chkSoloNumeri.TabIndex = 1;
            this.chkSoloNumeri.Text = "Accetta solo numeri";
            this.chkSoloNumeri.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSoloNumeri);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _34_userControl01_corretto.UserControl1 userControl11;
        private System.Windows.Forms.CheckBox chkSoloNumeri;
    }
}

