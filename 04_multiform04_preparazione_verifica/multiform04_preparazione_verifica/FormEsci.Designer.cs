namespace multiform04_preparazione_verifica
{
    partial class FormEsci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiE = new System.Windows.Forms.Button();
            this.btnNoE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuoi davvero uscire?";
            // 
            // btnSiE
            // 
            this.btnSiE.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSiE.Location = new System.Drawing.Point(16, 30);
            this.btnSiE.Name = "btnSiE";
            this.btnSiE.Size = new System.Drawing.Size(75, 23);
            this.btnSiE.TabIndex = 1;
            this.btnSiE.Text = "SI";
            this.btnSiE.UseVisualStyleBackColor = true;
            // 
            // btnNoE
            // 
            this.btnNoE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNoE.Location = new System.Drawing.Point(98, 29);
            this.btnNoE.Name = "btnNoE";
            this.btnNoE.Size = new System.Drawing.Size(75, 23);
            this.btnNoE.TabIndex = 2;
            this.btnNoE.Text = "NO";
            this.btnNoE.UseVisualStyleBackColor = true;
            // 
            // FormEsci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 85);
            this.Controls.Add(this.btnNoE);
            this.Controls.Add(this.btnSiE);
            this.Controls.Add(this.label1);
            this.Name = "FormEsci";
            this.Text = "FormEsci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiE;
        private System.Windows.Forms.Button btnNoE;
    }
}