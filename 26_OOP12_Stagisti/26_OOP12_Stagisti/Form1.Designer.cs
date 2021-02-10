
namespace _26_OOP12_Stagisti
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
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbSezione = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSpecializzazione = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAzienda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOreStage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnRicercaAzienda = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtPosizione = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(107, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(107, 38);
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
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(107, 64);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(100, 20);
            this.txtCitta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Città:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Classe:";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbClasse.Location = new System.Drawing.Point(107, 90);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(100, 21);
            this.cmbClasse.TabIndex = 7;
            // 
            // cmbSezione
            // 
            this.cmbSezione.FormattingEnabled = true;
            this.cmbSezione.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cmbSezione.Location = new System.Drawing.Point(316, 16);
            this.cmbSezione.Name = "cmbSezione";
            this.cmbSezione.Size = new System.Drawing.Size(100, 21);
            this.cmbSezione.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sezione:";
            // 
            // cmbSpecializzazione
            // 
            this.cmbSpecializzazione.FormattingEnabled = true;
            this.cmbSpecializzazione.Items.AddRange(new object[] {
            "INF",
            "MEC",
            "ELT"});
            this.cmbSpecializzazione.Location = new System.Drawing.Point(316, 43);
            this.cmbSpecializzazione.Name = "cmbSpecializzazione";
            this.cmbSpecializzazione.Size = new System.Drawing.Size(100, 21);
            this.cmbSpecializzazione.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Specializzazione:";
            // 
            // cmbAzienda
            // 
            this.cmbAzienda.FormattingEnabled = true;
            this.cmbAzienda.Items.AddRange(new object[] {
            "Azienda 1",
            "Azienda 2",
            "Azienda 3"});
            this.cmbAzienda.Location = new System.Drawing.Point(316, 70);
            this.cmbAzienda.Name = "cmbAzienda";
            this.cmbAzienda.Size = new System.Drawing.Size(100, 21);
            this.cmbAzienda.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Azienda:";
            // 
            // txtOreStage
            // 
            this.txtOreStage.Location = new System.Drawing.Point(316, 97);
            this.txtOreStage.Name = "txtOreStage";
            this.txtOreStage.Size = new System.Drawing.Size(100, 20);
            this.txtOreStage.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ore:";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(16, 135);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(191, 40);
            this.btnInserisci.TabIndex = 16;
            this.btnInserisci.Text = "INSERISCI";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnRicercaAzienda
            // 
            this.btnRicercaAzienda.Location = new System.Drawing.Point(225, 135);
            this.btnRicercaAzienda.Name = "btnRicercaAzienda";
            this.btnRicercaAzienda.Size = new System.Drawing.Size(191, 40);
            this.btnRicercaAzienda.TabIndex = 17;
            this.btnRicercaAzienda.Text = "RICERCA AZIENDA";
            this.btnRicercaAzienda.UseVisualStyleBackColor = true;
            this.btnRicercaAzienda.Click += new System.EventHandler(this.btnRicercaAzienda_Click);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(16, 194);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(400, 204);
            this.dgvStudenti.TabIndex = 18;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(180, 414);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(236, 40);
            this.btnElimina.TabIndex = 19;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // txtPosizione
            // 
            this.txtPosizione.Location = new System.Drawing.Point(74, 425);
            this.txtPosizione.Name = "txtPosizione";
            this.txtPosizione.Size = new System.Drawing.Size(100, 20);
            this.txtPosizione.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Posizione:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 476);
            this.Controls.Add(this.txtPosizione);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnRicercaAzienda);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtOreStage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAzienda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSpecializzazione);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSezione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbSezione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSpecializzazione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAzienda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOreStage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnRicercaAzienda;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtPosizione;
        private System.Windows.Forms.Label label9;
    }
}

