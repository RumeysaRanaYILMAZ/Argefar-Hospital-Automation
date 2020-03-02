namespace WindowsFormsApp5
{
    partial class FormRandevuAl
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
            this.textBoxRandevuHastaTc = new System.Windows.Forms.TextBox();
            this.textBoxRandevuBrans = new System.Windows.Forms.TextBox();
            this.textBoxRandevuDoktorTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHastaTC = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxRandevuHastaTc
            // 
            this.textBoxRandevuHastaTc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxRandevuHastaTc.Location = new System.Drawing.Point(170, 78);
            this.textBoxRandevuHastaTc.Name = "textBoxRandevuHastaTc";
            this.textBoxRandevuHastaTc.Size = new System.Drawing.Size(270, 22);
            this.textBoxRandevuHastaTc.TabIndex = 19;
            // 
            // textBoxRandevuBrans
            // 
            this.textBoxRandevuBrans.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxRandevuBrans.Location = new System.Drawing.Point(170, 153);
            this.textBoxRandevuBrans.Name = "textBoxRandevuBrans";
            this.textBoxRandevuBrans.Size = new System.Drawing.Size(270, 22);
            this.textBoxRandevuBrans.TabIndex = 18;
            // 
            // textBoxRandevuDoktorTc
            // 
            this.textBoxRandevuDoktorTc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxRandevuDoktorTc.Location = new System.Drawing.Point(170, 114);
            this.textBoxRandevuDoktorTc.Name = "textBoxRandevuDoktorTc";
            this.textBoxRandevuDoktorTc.Size = new System.Drawing.Size(270, 22);
            this.textBoxRandevuDoktorTc.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Branş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doktorun T.C No :";
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.AutoSize = true;
            this.lblHastaTC.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaTC.Location = new System.Drawing.Point(25, 77);
            this.lblHastaTC.Name = "lblHastaTC";
            this.lblHastaTC.Size = new System.Drawing.Size(131, 19);
            this.lblHastaTC.TabIndex = 12;
            this.lblHastaTC.Tag = "";
            this.lblHastaTC.Text = "Hastanın T.C No :";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(28, 41);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(47, 22);
            this.lblTarih.TabIndex = 11;
            this.lblTarih.Text = "Tarih :";
            this.lblTarih.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 57);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // FormRandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 293);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRandevuHastaTc);
            this.Controls.Add(this.textBoxRandevuBrans);
            this.Controls.Add(this.textBoxRandevuDoktorTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHastaTC);
            this.Controls.Add(this.lblTarih);
            this.Name = "FormRandevuAl";
            this.Text = "FormRandevuAl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRandevuHastaTc;
        private System.Windows.Forms.TextBox textBoxRandevuBrans;
        private System.Windows.Forms.TextBox textBoxRandevuDoktorTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}