namespace WindowsFormsApp5
{
    partial class FormBilgileriGoruntue
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
            this.checkBoxBireyselYillik = new System.Windows.Forms.CheckBox();
            this.checkBoxAileYillik = new System.Windows.Forms.CheckBox();
            this.btnYillikGiderHesapla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVatandasİlacGörüntüle = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGorunmez = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVatandasİlacGörüntüle)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxBireyselYillik
            // 
            this.checkBoxBireyselYillik.AutoSize = true;
            this.checkBoxBireyselYillik.Location = new System.Drawing.Point(91, 48);
            this.checkBoxBireyselYillik.Name = "checkBoxBireyselYillik";
            this.checkBoxBireyselYillik.Size = new System.Drawing.Size(196, 21);
            this.checkBoxBireyselYillik.TabIndex = 0;
            this.checkBoxBireyselYillik.Text = "Bireysel Yıllık Sağlık Gideri";
            this.checkBoxBireyselYillik.UseVisualStyleBackColor = true;
            // 
            // checkBoxAileYillik
            // 
            this.checkBoxAileYillik.AutoSize = true;
            this.checkBoxAileYillik.Location = new System.Drawing.Point(91, 88);
            this.checkBoxAileYillik.Name = "checkBoxAileYillik";
            this.checkBoxAileYillik.Size = new System.Drawing.Size(188, 21);
            this.checkBoxAileYillik.TabIndex = 1;
            this.checkBoxAileYillik.Text = "Ailenin Yıllık Sağlık Gideri";
            this.checkBoxAileYillik.UseVisualStyleBackColor = true;
            // 
            // btnYillikGiderHesapla
            // 
            this.btnYillikGiderHesapla.Location = new System.Drawing.Point(447, 48);
            this.btnYillikGiderHesapla.Name = "btnYillikGiderHesapla";
            this.btnYillikGiderHesapla.Size = new System.Drawing.Size(142, 61);
            this.btnYillikGiderHesapla.TabIndex = 2;
            this.btnYillikGiderHesapla.Text = "Hesapla";
            this.btnYillikGiderHesapla.UseVisualStyleBackColor = true;
            this.btnYillikGiderHesapla.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnYillikGiderHesapla);
            this.panel1.Controls.Add(this.checkBoxBireyselYillik);
            this.panel1.Controls.Add(this.checkBoxAileYillik);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 153);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aldığınız İlacı Görüntülemek İçin Muayene Tarihini Seçiniz :";
            // 
            // dataGridViewVatandasİlacGörüntüle
            // 
            this.dataGridViewVatandasİlacGörüntüle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVatandasİlacGörüntüle.Location = new System.Drawing.Point(459, 238);
            this.dataGridViewVatandasİlacGörüntüle.Name = "dataGridViewVatandasİlacGörüntüle";
            this.dataGridViewVatandasİlacGörüntüle.RowTemplate.Height = 24;
            this.dataGridViewVatandasİlacGörüntüle.Size = new System.Drawing.Size(192, 232);
            this.dataGridViewVatandasİlacGörüntüle.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "İlaçları Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelGorunmez
            // 
            this.labelGorunmez.AutoSize = true;
            this.labelGorunmez.Location = new System.Drawing.Point(693, 271);
            this.labelGorunmez.Name = "labelGorunmez";
            this.labelGorunmez.Size = new System.Drawing.Size(46, 17);
            this.labelGorunmez.TabIndex = 9;
            this.labelGorunmez.Text = "label3";
            this.labelGorunmez.Visible = false;
            this.labelGorunmez.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormBilgileriGoruntue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 510);
            this.Controls.Add(this.labelGorunmez);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewVatandasİlacGörüntüle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormBilgileriGoruntue";
            this.Text = "FormBilesenEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVatandasİlacGörüntüle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBireyselYillik;
        private System.Windows.Forms.CheckBox checkBoxAileYillik;
        private System.Windows.Forms.Button btnYillikGiderHesapla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVatandasİlacGörüntüle;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelGorunmez;
    }
}