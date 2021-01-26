
namespace _25_OOP11_Mondo_Animale
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
            this.btnCavallo = new System.Windows.Forms.Button();
            this.btnUomo = new System.Windows.Forms.Button();
            this.btnCorvo = new System.Windows.Forms.Button();
            this.btnTonno = new System.Windows.Forms.Button();
            this.btnUccello = new System.Windows.Forms.Button();
            this.btnPinguino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCavallo
            // 
            this.btnCavallo.Location = new System.Drawing.Point(13, 13);
            this.btnCavallo.Name = "btnCavallo";
            this.btnCavallo.Size = new System.Drawing.Size(75, 23);
            this.btnCavallo.TabIndex = 0;
            this.btnCavallo.Text = "Cavallo";
            this.btnCavallo.UseVisualStyleBackColor = true;
            this.btnCavallo.Click += new System.EventHandler(this.btnCavallo_Click);
            // 
            // btnUomo
            // 
            this.btnUomo.Location = new System.Drawing.Point(94, 12);
            this.btnUomo.Name = "btnUomo";
            this.btnUomo.Size = new System.Drawing.Size(75, 23);
            this.btnUomo.TabIndex = 1;
            this.btnUomo.Text = "Uomo";
            this.btnUomo.UseVisualStyleBackColor = true;
            this.btnUomo.Click += new System.EventHandler(this.btnUomo_Click);
            // 
            // btnCorvo
            // 
            this.btnCorvo.Location = new System.Drawing.Point(175, 13);
            this.btnCorvo.Name = "btnCorvo";
            this.btnCorvo.Size = new System.Drawing.Size(75, 23);
            this.btnCorvo.TabIndex = 2;
            this.btnCorvo.Text = "Corvo";
            this.btnCorvo.UseVisualStyleBackColor = true;
            this.btnCorvo.Click += new System.EventHandler(this.btnCorvo_Click);
            // 
            // btnTonno
            // 
            this.btnTonno.Location = new System.Drawing.Point(256, 13);
            this.btnTonno.Name = "btnTonno";
            this.btnTonno.Size = new System.Drawing.Size(75, 23);
            this.btnTonno.TabIndex = 3;
            this.btnTonno.Text = "Tonno";
            this.btnTonno.UseVisualStyleBackColor = true;
            this.btnTonno.Click += new System.EventHandler(this.btnTonno_Click);
            // 
            // btnUccello
            // 
            this.btnUccello.Location = new System.Drawing.Point(337, 13);
            this.btnUccello.Name = "btnUccello";
            this.btnUccello.Size = new System.Drawing.Size(75, 23);
            this.btnUccello.TabIndex = 4;
            this.btnUccello.Text = "Uccello";
            this.btnUccello.UseVisualStyleBackColor = true;
            this.btnUccello.Click += new System.EventHandler(this.btnUccello_Click);
            // 
            // btnPinguino
            // 
            this.btnPinguino.Location = new System.Drawing.Point(418, 13);
            this.btnPinguino.Name = "btnPinguino";
            this.btnPinguino.Size = new System.Drawing.Size(75, 23);
            this.btnPinguino.TabIndex = 5;
            this.btnPinguino.Text = "Pinguino";
            this.btnPinguino.UseVisualStyleBackColor = true;
            this.btnPinguino.Click += new System.EventHandler(this.btnPinguino_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 51);
            this.Controls.Add(this.btnPinguino);
            this.Controls.Add(this.btnUccello);
            this.Controls.Add(this.btnTonno);
            this.Controls.Add(this.btnCorvo);
            this.Controls.Add(this.btnUomo);
            this.Controls.Add(this.btnCavallo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCavallo;
        private System.Windows.Forms.Button btnUomo;
        private System.Windows.Forms.Button btnCorvo;
        private System.Windows.Forms.Button btnTonno;
        private System.Windows.Forms.Button btnUccello;
        private System.Windows.Forms.Button btnPinguino;
    }
}

