namespace _15_queue01_pronto_soccorso
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
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAggiungiPaziente = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblColore = new System.Windows.Forms.Label();
            this.lblEtà = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnProssimoPaziente = new System.Windows.Forms.Button();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(87, 38);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 20);
            this.txtEtà.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Età:";
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(87, 64);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 20);
            this.txtColore.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colore:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(87, 90);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Temperatura:";
            // 
            // btnAggiungiPaziente
            // 
            this.btnAggiungiPaziente.Location = new System.Drawing.Point(13, 127);
            this.btnAggiungiPaziente.Name = "btnAggiungiPaziente";
            this.btnAggiungiPaziente.Size = new System.Drawing.Size(174, 23);
            this.btnAggiungiPaziente.TabIndex = 8;
            this.btnAggiungiPaziente.Text = "Aggiungi";
            this.btnAggiungiPaziente.UseVisualStyleBackColor = true;
            this.btnAggiungiPaziente.Click += new System.EventHandler(this.btnAggiungiPaziente_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(254, 100);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(70, 13);
            this.lblTemperatura.TabIndex = 14;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // lblColore
            // 
            this.lblColore.AutoSize = true;
            this.lblColore.Location = new System.Drawing.Point(254, 74);
            this.lblColore.Name = "lblColore";
            this.lblColore.Size = new System.Drawing.Size(40, 13);
            this.lblColore.TabIndex = 13;
            this.lblColore.Text = "Colore:";
            // 
            // lblEtà
            // 
            this.lblEtà.AutoSize = true;
            this.lblEtà.Location = new System.Drawing.Point(254, 48);
            this.lblEtà.Name = "lblEtà";
            this.lblEtà.Size = new System.Drawing.Size(26, 13);
            this.lblEtà.TabIndex = 12;
            this.lblEtà.Text = "Età:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(254, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // btnProssimoPaziente
            // 
            this.btnProssimoPaziente.Location = new System.Drawing.Point(257, 127);
            this.btnProssimoPaziente.Name = "btnProssimoPaziente";
            this.btnProssimoPaziente.Size = new System.Drawing.Size(177, 23);
            this.btnProssimoPaziente.TabIndex = 15;
            this.btnProssimoPaziente.Text = "Prossimo paziente";
            this.btnProssimoPaziente.UseVisualStyleBackColor = true;
            this.btnProssimoPaziente.Click += new System.EventHandler(this.btnProssimoPaziente_Click);
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Location = new System.Drawing.Point(139, 156);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(173, 23);
            this.btnTemperatura.TabIndex = 16;
            this.btnTemperatura.Text = "Temperatura max e min";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 196);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.btnProssimoPaziente);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblColore);
            this.Controls.Add(this.lblEtà);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAggiungiPaziente);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAggiungiPaziente;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblColore;
        private System.Windows.Forms.Label lblEtà;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnProssimoPaziente;
        private System.Windows.Forms.Button btnTemperatura;
    }
}

