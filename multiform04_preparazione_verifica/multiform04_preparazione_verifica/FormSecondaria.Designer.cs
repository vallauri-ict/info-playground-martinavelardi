namespace multiform04_preparazione_verifica
{
    partial class FormSecondaria
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
            this.txtNomeFS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEtàFS = new System.Windows.Forms.TextBox();
            this.btnOkFS = new System.Windows.Forms.Button();
            this.btnCancelFS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNomeFS
            // 
            this.txtNomeFS.Location = new System.Drawing.Point(61, 13);
            this.txtNomeFS.Name = "txtNomeFS";
            this.txtNomeFS.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Età: ";
            // 
            // txtEtàFS
            // 
            this.txtEtàFS.Location = new System.Drawing.Point(52, 55);
            this.txtEtàFS.Name = "txtEtàFS";
            this.txtEtàFS.Size = new System.Drawing.Size(100, 20);
            this.txtEtàFS.TabIndex = 3;
            // 
            // btnOkFS
            // 
            this.btnOkFS.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkFS.Location = new System.Drawing.Point(19, 98);
            this.btnOkFS.Name = "btnOkFS";
            this.btnOkFS.Size = new System.Drawing.Size(75, 23);
            this.btnOkFS.TabIndex = 4;
            this.btnOkFS.Text = "OK";
            this.btnOkFS.UseVisualStyleBackColor = true;
            this.btnOkFS.Click += new System.EventHandler(this.btnOkFS_Click);
            // 
            // btnCancelFS
            // 
            this.btnCancelFS.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelFS.Location = new System.Drawing.Point(101, 97);
            this.btnCancelFS.Name = "btnCancelFS";
            this.btnCancelFS.Size = new System.Drawing.Size(75, 23);
            this.btnCancelFS.TabIndex = 5;
            this.btnCancelFS.Text = "ANNULLA";
            this.btnCancelFS.UseVisualStyleBackColor = true;
            this.btnCancelFS.Click += new System.EventHandler(this.btnCancelFS_Click);
            // 
            // FormSecondaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 144);
            this.Controls.Add(this.btnCancelFS);
            this.Controls.Add(this.btnOkFS);
            this.Controls.Add(this.txtEtàFS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFS);
            this.Controls.Add(this.label1);
            this.Name = "FormSecondaria";
            this.Text = "FormSecondaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEtàFS;
        private System.Windows.Forms.Button btnOkFS;
        private System.Windows.Forms.Button btnCancelFS;
    }
}