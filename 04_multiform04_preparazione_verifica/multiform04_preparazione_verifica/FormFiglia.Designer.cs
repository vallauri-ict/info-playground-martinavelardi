namespace multiform04_preparazione_verifica
{
    partial class FormFiglia
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
            this.txtFormFiglia = new System.Windows.Forms.TextBox();
            this.btnModificaFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFormFiglia
            // 
            this.txtFormFiglia.Location = new System.Drawing.Point(13, 13);
            this.txtFormFiglia.Name = "txtFormFiglia";
            this.txtFormFiglia.Size = new System.Drawing.Size(100, 20);
            this.txtFormFiglia.TabIndex = 0;
            // 
            // btnModificaFF
            // 
            this.btnModificaFF.Location = new System.Drawing.Point(120, 13);
            this.btnModificaFF.Name = "btnModificaFF";
            this.btnModificaFF.Size = new System.Drawing.Size(75, 23);
            this.btnModificaFF.TabIndex = 1;
            this.btnModificaFF.Text = "MODIFICA";
            this.btnModificaFF.UseVisualStyleBackColor = true;
            this.btnModificaFF.Click += new System.EventHandler(this.btnModificaFF_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 48);
            this.Controls.Add(this.btnModificaFF);
            this.Controls.Add(this.txtFormFiglia);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormFiglia;
        private System.Windows.Forms.Button btnModificaFF;
    }
}