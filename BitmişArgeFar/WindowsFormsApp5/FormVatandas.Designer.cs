namespace WindowsFormsApp5
{
    partial class FormVatandas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVtndsGrs = new System.Windows.Forms.Button();
            this.textBoxVatandasTCGiris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVtndsGrs);
            this.groupBox1.Controls.Add(this.textBoxVatandasTCGiris);
            this.groupBox1.Location = new System.Drawing.Point(23, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "T.C Kimlik No Giriniz:";
            // 
            // btnVtndsGrs
            // 
            this.btnVtndsGrs.Location = new System.Drawing.Point(316, 59);
            this.btnVtndsGrs.Name = "btnVtndsGrs";
            this.btnVtndsGrs.Size = new System.Drawing.Size(147, 52);
            this.btnVtndsGrs.TabIndex = 1;
            this.btnVtndsGrs.Text = "Giris";
            this.btnVtndsGrs.UseVisualStyleBackColor = true;
            this.btnVtndsGrs.Click += new System.EventHandler(this.btnVtndsGrs_Click);
            // 
            // textBoxVatandasTCGiris
            // 
            this.textBoxVatandasTCGiris.Location = new System.Drawing.Point(56, 74);
            this.textBoxVatandasTCGiris.Name = "textBoxVatandasTCGiris";
            this.textBoxVatandasTCGiris.Size = new System.Drawing.Size(217, 22);
            this.textBoxVatandasTCGiris.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // FormVatandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVatandas";
            this.Text = "Form Vatandas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVtndsGrs;
        private System.Windows.Forms.TextBox textBoxVatandasTCGiris;
        private System.Windows.Forms.Label label2;
    }
}