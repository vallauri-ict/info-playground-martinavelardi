namespace _20_OOP07_Persone_Studenti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listStudenti = new System.Windows.Forms.ListView();
            this.btnAggiungiVoto = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(74, 39);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome:";
            // 
            // txtSesso
            // 
            this.txtSesso.Location = new System.Drawing.Point(74, 65);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(100, 20);
            this.txtSesso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sesso:";
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(74, 91);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 20);
            this.txtEtà.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Età:";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(17, 143);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(157, 23);
            this.btnInserisci.TabIndex = 9;
            this.btnInserisci.Text = "INSERISCI";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(73, 202);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(100, 20);
            this.txtVoto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Voto:";
            // 
            // listStudenti
            // 
            this.listStudenti.HideSelection = false;
            this.listStudenti.Location = new System.Drawing.Point(180, 14);
            this.listStudenti.Name = "listStudenti";
            this.listStudenti.Size = new System.Drawing.Size(276, 152);
            this.listStudenti.TabIndex = 12;
            this.listStudenti.UseCompatibleStateImageBehavior = false;
            this.listStudenti.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAggiungiVoto
            // 
            this.btnAggiungiVoto.Location = new System.Drawing.Point(180, 200);
            this.btnAggiungiVoto.Name = "btnAggiungiVoto";
            this.btnAggiungiVoto.Size = new System.Drawing.Size(157, 23);
            this.btnAggiungiVoto.TabIndex = 13;
            this.btnAggiungiVoto.Text = "AGGIUNGI VOTO";
            this.btnAggiungiVoto.UseVisualStyleBackColor = true;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(462, 14);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(157, 23);
            this.btnVisualizza.TabIndex = 14;
            this.btnVisualizza.Text = "VISUALIZZA STUDENTE";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 234);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAggiungiVoto);
            this.Controls.Add(this.listStudenti);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listStudenti;
        private System.Windows.Forms.Button btnAggiungiVoto;
        private System.Windows.Forms.Button btnVisualizza;
    }
}

