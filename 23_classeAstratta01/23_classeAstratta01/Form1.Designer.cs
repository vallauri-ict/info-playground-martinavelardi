﻿
namespace _23_classeAstratta01
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
            this.btnStampaStudenti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStampaStudenti
            // 
            this.btnStampaStudenti.Location = new System.Drawing.Point(13, 13);
            this.btnStampaStudenti.Name = "btnStampaStudenti";
            this.btnStampaStudenti.Size = new System.Drawing.Size(105, 43);
            this.btnStampaStudenti.TabIndex = 0;
            this.btnStampaStudenti.Text = "Stampa studenti";
            this.btnStampaStudenti.UseVisualStyleBackColor = true;
            this.btnStampaStudenti.Click += new System.EventHandler(this.btnStampaStudenti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStampaStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStampaStudenti;
    }
}

