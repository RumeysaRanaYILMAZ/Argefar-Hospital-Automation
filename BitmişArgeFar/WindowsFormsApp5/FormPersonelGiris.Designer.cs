namespace WindowsFormsApp5
{
    partial class FormPersonelGiris
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
            this.rdbtnDoktor = new System.Windows.Forms.RadioButton();
            this.rdbtnPersonel = new System.Windows.Forms.RadioButton();
            this.groupBoxDoktor = new System.Windows.Forms.GroupBox();
            this.textBoxDoktorTcAl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDktrGrs = new System.Windows.Forms.Button();
            this.groupBoxPersonel = new System.Windows.Forms.GroupBox();
            this.btnPrsnlGrs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDoktor.SuspendLayout();
            this.groupBoxPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnDoktor
            // 
            this.rdbtnDoktor.AutoSize = true;
            this.rdbtnDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnDoktor.Location = new System.Drawing.Point(163, 60);
            this.rdbtnDoktor.Name = "rdbtnDoktor";
            this.rdbtnDoktor.Size = new System.Drawing.Size(90, 29);
            this.rdbtnDoktor.TabIndex = 0;
            this.rdbtnDoktor.TabStop = true;
            this.rdbtnDoktor.Text = "Doktor";
            this.rdbtnDoktor.UseVisualStyleBackColor = true;
            this.rdbtnDoktor.CheckedChanged += new System.EventHandler(this.rdbtnDoktor_CheckedChanged);
            // 
            // rdbtnPersonel
            // 
            this.rdbtnPersonel.AutoSize = true;
            this.rdbtnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnPersonel.Location = new System.Drawing.Point(306, 60);
            this.rdbtnPersonel.Name = "rdbtnPersonel";
            this.rdbtnPersonel.Size = new System.Drawing.Size(110, 29);
            this.rdbtnPersonel.TabIndex = 1;
            this.rdbtnPersonel.TabStop = true;
            this.rdbtnPersonel.Text = "Personel";
            this.rdbtnPersonel.UseVisualStyleBackColor = true;
            this.rdbtnPersonel.CheckedChanged += new System.EventHandler(this.rdbtnPersonel_CheckedChanged);
            // 
            // groupBoxDoktor
            // 
            this.groupBoxDoktor.Controls.Add(this.textBoxDoktorTcAl);
            this.groupBoxDoktor.Controls.Add(this.label1);
            this.groupBoxDoktor.Controls.Add(this.btnDktrGrs);
            this.groupBoxDoktor.Location = new System.Drawing.Point(58, 116);
            this.groupBoxDoktor.Name = "groupBoxDoktor";
            this.groupBoxDoktor.Size = new System.Drawing.Size(503, 151);
            this.groupBoxDoktor.TabIndex = 2;
            this.groupBoxDoktor.TabStop = false;
            this.groupBoxDoktor.Text = "Giriş";
            this.groupBoxDoktor.Visible = false;
            // 
            // textBoxDoktorTcAl
            // 
            this.textBoxDoktorTcAl.Location = new System.Drawing.Point(38, 79);
            this.textBoxDoktorTcAl.Name = "textBoxDoktorTcAl";
            this.textBoxDoktorTcAl.Size = new System.Drawing.Size(230, 22);
            this.textBoxDoktorTcAl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C Kimlik No Giriniz:";
            // 
            // btnDktrGrs
            // 
            this.btnDktrGrs.Location = new System.Drawing.Point(320, 52);
            this.btnDktrGrs.Name = "btnDktrGrs";
            this.btnDktrGrs.Size = new System.Drawing.Size(127, 58);
            this.btnDktrGrs.TabIndex = 0;
            this.btnDktrGrs.Text = "Giriş";
            this.btnDktrGrs.UseVisualStyleBackColor = true;
            this.btnDktrGrs.Click += new System.EventHandler(this.btnDktrGrs_Click);
            // 
            // groupBoxPersonel
            // 
            this.groupBoxPersonel.Controls.Add(this.btnPrsnlGrs);
            this.groupBoxPersonel.Location = new System.Drawing.Point(38, 148);
            this.groupBoxPersonel.Name = "groupBoxPersonel";
            this.groupBoxPersonel.Size = new System.Drawing.Size(503, 139);
            this.groupBoxPersonel.TabIndex = 3;
            this.groupBoxPersonel.TabStop = false;
            this.groupBoxPersonel.Text = "Giriş";
            this.groupBoxPersonel.Visible = false;
            this.groupBoxPersonel.Enter += new System.EventHandler(this.groupBoxPersonel_Enter);
            // 
            // btnPrsnlGrs
            // 
            this.btnPrsnlGrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrsnlGrs.Location = new System.Drawing.Point(119, 50);
            this.btnPrsnlGrs.Name = "btnPrsnlGrs";
            this.btnPrsnlGrs.Size = new System.Drawing.Size(211, 61);
            this.btnPrsnlGrs.TabIndex = 0;
            this.btnPrsnlGrs.Text = "Giriş";
            this.btnPrsnlGrs.UseVisualStyleBackColor = true;
            this.btnPrsnlGrs.Click += new System.EventHandler(this.btnPrsnlGrs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // FormPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxDoktor);
            this.Controls.Add(this.groupBoxPersonel);
            this.Controls.Add(this.rdbtnPersonel);
            this.Controls.Add(this.rdbtnDoktor);
            this.Name = "FormPersonelGiris";
            this.Text = "Personel Giris";
            this.Load += new System.EventHandler(this.FormPersonelGiris_Load);
            this.groupBoxDoktor.ResumeLayout(false);
            this.groupBoxDoktor.PerformLayout();
            this.groupBoxPersonel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnDoktor;
        private System.Windows.Forms.RadioButton rdbtnPersonel;
        private System.Windows.Forms.GroupBox groupBoxDoktor;
        private System.Windows.Forms.TextBox textBoxDoktorTcAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDktrGrs;
        private System.Windows.Forms.GroupBox groupBoxPersonel;
        private System.Windows.Forms.Button btnPrsnlGrs;
        private System.Windows.Forms.Label label2;
    }
}