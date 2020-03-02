namespace WindowsFormsApp5
{
    partial class FormMuayenGuncelle
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
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblHastaTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMuayeneGuncelleDoktorTc = new System.Windows.Forms.TextBox();
            this.textBoxMuayeneGuncelleIlac = new System.Windows.Forms.TextBox();
            this.textBoxMuayeneGuncelleBrans = new System.Windows.Forms.TextBox();
            this.btnMGTamam = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelGorunmezDoktor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(35, 40);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(47, 22);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih :";
            this.lblTarih.UseCompatibleTextRendering = true;
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.AutoSize = true;
            this.lblHastaTC.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaTC.Location = new System.Drawing.Point(32, 76);
            this.lblHastaTC.Name = "lblHastaTC";
            this.lblHastaTC.Size = new System.Drawing.Size(131, 19);
            this.lblHastaTC.TabIndex = 2;
            this.lblHastaTC.Tag = "";
            this.lblHastaTC.Text = "Hastanın T.C No :";
            this.lblHastaTC.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doktorun T.C No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "İlaç :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Branş :";
            // 
            // textBoxMuayeneGuncelleDoktorTc
            // 
            this.textBoxMuayeneGuncelleDoktorTc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxMuayeneGuncelleDoktorTc.Location = new System.Drawing.Point(177, 113);
            this.textBoxMuayeneGuncelleDoktorTc.Name = "textBoxMuayeneGuncelleDoktorTc";
            this.textBoxMuayeneGuncelleDoktorTc.Size = new System.Drawing.Size(270, 22);
            this.textBoxMuayeneGuncelleDoktorTc.TabIndex = 6;
            // 
            // textBoxMuayeneGuncelleIlac
            // 
            this.textBoxMuayeneGuncelleIlac.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxMuayeneGuncelleIlac.Location = new System.Drawing.Point(177, 148);
            this.textBoxMuayeneGuncelleIlac.Name = "textBoxMuayeneGuncelleIlac";
            this.textBoxMuayeneGuncelleIlac.Size = new System.Drawing.Size(270, 22);
            this.textBoxMuayeneGuncelleIlac.TabIndex = 7;
            // 
            // textBoxMuayeneGuncelleBrans
            // 
            this.textBoxMuayeneGuncelleBrans.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxMuayeneGuncelleBrans.Location = new System.Drawing.Point(177, 180);
            this.textBoxMuayeneGuncelleBrans.Name = "textBoxMuayeneGuncelleBrans";
            this.textBoxMuayeneGuncelleBrans.Size = new System.Drawing.Size(270, 22);
            this.textBoxMuayeneGuncelleBrans.TabIndex = 8;
            // 
            // btnMGTamam
            // 
            this.btnMGTamam.Location = new System.Drawing.Point(307, 220);
            this.btnMGTamam.Name = "btnMGTamam";
            this.btnMGTamam.Size = new System.Drawing.Size(140, 36);
            this.btnMGTamam.TabIndex = 11;
            this.btnMGTamam.Text = "Tamam";
            this.btnMGTamam.UseVisualStyleBackColor = true;
            this.btnMGTamam.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // labelGorunmezDoktor
            // 
            this.labelGorunmezDoktor.AutoSize = true;
            this.labelGorunmezDoktor.Location = new System.Drawing.Point(400, 40);
            this.labelGorunmezDoktor.Name = "labelGorunmezDoktor";
            this.labelGorunmezDoktor.Size = new System.Drawing.Size(46, 17);
            this.labelGorunmezDoktor.TabIndex = 14;
            this.labelGorunmezDoktor.Text = "label4";
            this.labelGorunmezDoktor.Visible = false;
            // 
            // FormMuayenGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 268);
            this.Controls.Add(this.labelGorunmezDoktor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnMGTamam);
            this.Controls.Add(this.textBoxMuayeneGuncelleBrans);
            this.Controls.Add(this.textBoxMuayeneGuncelleIlac);
            this.Controls.Add(this.textBoxMuayeneGuncelleDoktorTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHastaTC);
            this.Controls.Add(this.lblTarih);
            this.Name = "FormMuayenGuncelle";
            this.Text = "FormMuayenGuncelle";
            this.Load += new System.EventHandler(this.FormMuayenGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMuayeneGuncelleDoktorTc;
        private System.Windows.Forms.TextBox textBoxMuayeneGuncelleIlac;
        private System.Windows.Forms.TextBox textBoxMuayeneGuncelleBrans;
        private System.Windows.Forms.Button btnMGTamam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label labelGorunmezDoktor;
    }
}