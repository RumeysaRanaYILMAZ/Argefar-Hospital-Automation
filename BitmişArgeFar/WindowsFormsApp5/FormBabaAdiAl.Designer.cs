namespace WindowsFormsApp5
{
    partial class FormBabaAdiAl
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
            this.btnBabaAdiTamam = new System.Windows.Forms.Button();
            this.textBoxBabaAdiAlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBabaAdiTamam
            // 
            this.btnBabaAdiTamam.Location = new System.Drawing.Point(109, 91);
            this.btnBabaAdiTamam.Name = "btnBabaAdiTamam";
            this.btnBabaAdiTamam.Size = new System.Drawing.Size(75, 23);
            this.btnBabaAdiTamam.TabIndex = 0;
            this.btnBabaAdiTamam.Text = "Tamam";
            this.btnBabaAdiTamam.UseVisualStyleBackColor = true;
            this.btnBabaAdiTamam.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBabaAdiAlan
            // 
            this.textBoxBabaAdiAlan.Location = new System.Drawing.Point(15, 53);
            this.textBoxBabaAdiAlan.Name = "textBoxBabaAdiAlan";
            this.textBoxBabaAdiAlan.Size = new System.Drawing.Size(169, 22);
            this.textBoxBabaAdiAlan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aile Reisinin Adını Giriniz :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormBabaAdiAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBabaAdiAlan);
            this.Controls.Add(this.btnBabaAdiTamam);
            this.Name = "FormBabaAdiAl";
            this.Text = "FormBabaAdiAl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBabaAdiTamam;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxBabaAdiAlan;
    }
}