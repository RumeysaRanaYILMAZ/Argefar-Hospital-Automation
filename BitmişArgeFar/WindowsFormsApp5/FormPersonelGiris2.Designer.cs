namespace WindowsFormsApp5
{
    partial class FormPersonelGiris2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHasta = new System.Windows.Forms.Panel();
            this.dataGridViewPersonelFormHasta = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.textBoxHastaSosyalGuvence = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxHastaTc = new System.Windows.Forms.TextBox();
            this.textBoxHastaAdi = new System.Windows.Forms.TextBox();
            this.textBoxHastaAileHekimi = new System.Windows.Forms.TextBox();
            this.textBoxHastaDogumYili = new System.Windows.Forms.TextBox();
            this.textBoxHastaSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHastaTC = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.pnlDoktor = new System.Windows.Forms.Panel();
            this.dataGridViewFormPersonelDoktor = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxDoktorTc = new System.Windows.Forms.TextBox();
            this.textBoxDoktorAdi = new System.Windows.Forms.TextBox();
            this.textBoxDoktorBransi = new System.Windows.Forms.TextBox();
            this.textBoxDoktorDogumYili = new System.Windows.Forms.TextBox();
            this.textBoxDoktorSoyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlIlac = new System.Windows.Forms.Panel();
            this.dataGridViewPersonelForm = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxİlacAdi = new System.Windows.Forms.TextBox();
            this.textBoxİlacFiyati = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlHasta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonelFormHasta)).BeginInit();
            this.pnlDoktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormPersonelDoktor)).BeginInit();
            this.pnlIlac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonelForm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Hasta";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 24);
            this.toolStripMenuItem2.Text = "Doktor";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem3.Text = "İlaç";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // pnlHasta
            // 
            this.pnlHasta.Controls.Add(this.dataGridViewPersonelFormHasta);
            this.pnlHasta.Controls.Add(this.button7);
            this.pnlHasta.Controls.Add(this.textBoxHastaSosyalGuvence);
            this.pnlHasta.Controls.Add(this.label4);
            this.pnlHasta.Controls.Add(this.button8);
            this.pnlHasta.Controls.Add(this.button9);
            this.pnlHasta.Controls.Add(this.textBoxHastaTc);
            this.pnlHasta.Controls.Add(this.textBoxHastaAdi);
            this.pnlHasta.Controls.Add(this.textBoxHastaAileHekimi);
            this.pnlHasta.Controls.Add(this.textBoxHastaDogumYili);
            this.pnlHasta.Controls.Add(this.textBoxHastaSoyadi);
            this.pnlHasta.Controls.Add(this.label2);
            this.pnlHasta.Controls.Add(this.label1);
            this.pnlHasta.Controls.Add(this.label3);
            this.pnlHasta.Controls.Add(this.lblHastaTC);
            this.pnlHasta.Controls.Add(this.lblTarih);
            this.pnlHasta.Location = new System.Drawing.Point(67, 54);
            this.pnlHasta.Name = "pnlHasta";
            this.pnlHasta.Size = new System.Drawing.Size(1023, 516);
            this.pnlHasta.TabIndex = 1;
            this.pnlHasta.Visible = false;
            // 
            // dataGridViewPersonelFormHasta
            // 
            this.dataGridViewPersonelFormHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonelFormHasta.Location = new System.Drawing.Point(561, 31);
            this.dataGridViewPersonelFormHasta.Name = "dataGridViewPersonelFormHasta";
            this.dataGridViewPersonelFormHasta.RowTemplate.Height = 24;
            this.dataGridViewPersonelFormHasta.Size = new System.Drawing.Size(410, 451);
            this.dataGridViewPersonelFormHasta.TabIndex = 26;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(197, 321);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 50);
            this.button7.TabIndex = 25;
            this.button7.Text = "Sil";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBoxHastaSosyalGuvence
            // 
            this.textBoxHastaSosyalGuvence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxHastaSosyalGuvence.Location = new System.Drawing.Point(256, 250);
            this.textBoxHastaSosyalGuvence.Name = "textBoxHastaSosyalGuvence";
            this.textBoxHastaSosyalGuvence.Size = new System.Drawing.Size(270, 22);
            this.textBoxHastaSosyalGuvence.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sosyal Güvence :";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(362, 320);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 51);
            this.button8.TabIndex = 24;
            this.button8.Text = "Güncelle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(45, 321);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 50);
            this.button9.TabIndex = 23;
            this.button9.Text = "Ekle";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBoxHastaTc
            // 
            this.textBoxHastaTc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxHastaTc.Location = new System.Drawing.Point(256, 79);
            this.textBoxHastaTc.Name = "textBoxHastaTc";
            this.textBoxHastaTc.Size = new System.Drawing.Size(270, 22);
            this.textBoxHastaTc.TabIndex = 20;
            // 
            // textBoxHastaAdi
            // 
            this.textBoxHastaAdi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxHastaAdi.Location = new System.Drawing.Point(256, 115);
            this.textBoxHastaAdi.Name = "textBoxHastaAdi";
            this.textBoxHastaAdi.Size = new System.Drawing.Size(270, 22);
            this.textBoxHastaAdi.TabIndex = 19;
            // 
            // textBoxHastaAileHekimi
            // 
            this.textBoxHastaAileHekimi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxHastaAileHekimi.Location = new System.Drawing.Point(256, 218);
            this.textBoxHastaAileHekimi.Name = "textBoxHastaAileHekimi";
            this.textBoxHastaAileHekimi.Size = new System.Drawing.Size(270, 22);
            this.textBoxHastaAileHekimi.TabIndex = 18;
            // 
            // textBoxHastaDogumYili
            // 
            this.textBoxHastaDogumYili.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxHastaDogumYili.Location = new System.Drawing.Point(256, 186);
            this.textBoxHastaDogumYili.Name = "textBoxHastaDogumYili";
            this.textBoxHastaDogumYili.Size = new System.Drawing.Size(270, 22);
            this.textBoxHastaDogumYili.TabIndex = 17;
            // 
            // textBoxHastaSoyadi
            // 
            this.textBoxHastaSoyadi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxHastaSoyadi.Location = new System.Drawing.Point(256, 151);
            this.textBoxHastaSoyadi.Name = "textBoxHastaSoyadi";
            this.textBoxHastaSoyadi.Size = new System.Drawing.Size(270, 22);
            this.textBoxHastaSoyadi.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doğum Yılı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aile Hekimi :";
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.AutoSize = true;
            this.lblHastaTC.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaTC.Location = new System.Drawing.Point(51, 82);
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
            this.lblTarih.Location = new System.Drawing.Point(51, 115);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(36, 22);
            this.lblTarih.TabIndex = 11;
            this.lblTarih.Text = "Adı :";
            this.lblTarih.UseCompatibleTextRendering = true;
            // 
            // pnlDoktor
            // 
            this.pnlDoktor.Controls.Add(this.dataGridViewFormPersonelDoktor);
            this.pnlDoktor.Controls.Add(this.button4);
            this.pnlDoktor.Controls.Add(this.button5);
            this.pnlDoktor.Controls.Add(this.button6);
            this.pnlDoktor.Controls.Add(this.textBoxDoktorTc);
            this.pnlDoktor.Controls.Add(this.textBoxDoktorAdi);
            this.pnlDoktor.Controls.Add(this.textBoxDoktorBransi);
            this.pnlDoktor.Controls.Add(this.textBoxDoktorDogumYili);
            this.pnlDoktor.Controls.Add(this.textBoxDoktorSoyadi);
            this.pnlDoktor.Controls.Add(this.label6);
            this.pnlDoktor.Controls.Add(this.label7);
            this.pnlDoktor.Controls.Add(this.label8);
            this.pnlDoktor.Controls.Add(this.label9);
            this.pnlDoktor.Controls.Add(this.label10);
            this.pnlDoktor.Location = new System.Drawing.Point(36, 85);
            this.pnlDoktor.Name = "pnlDoktor";
            this.pnlDoktor.Size = new System.Drawing.Size(1020, 543);
            this.pnlDoktor.TabIndex = 2;
            this.pnlDoktor.Visible = false;
            // 
            // dataGridViewFormPersonelDoktor
            // 
            this.dataGridViewFormPersonelDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormPersonelDoktor.Location = new System.Drawing.Point(533, 43);
            this.dataGridViewFormPersonelDoktor.Name = "dataGridViewFormPersonelDoktor";
            this.dataGridViewFormPersonelDoktor.RowTemplate.Height = 24;
            this.dataGridViewFormPersonelDoktor.Size = new System.Drawing.Size(458, 475);
            this.dataGridViewFormPersonelDoktor.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 50);
            this.button4.TabIndex = 25;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(345, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 51);
            this.button5.TabIndex = 24;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 50);
            this.button6.TabIndex = 23;
            this.button6.Text = "Ekle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxDoktorTc
            // 
            this.textBoxDoktorTc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxDoktorTc.Location = new System.Drawing.Point(236, 160);
            this.textBoxDoktorTc.Name = "textBoxDoktorTc";
            this.textBoxDoktorTc.Size = new System.Drawing.Size(270, 22);
            this.textBoxDoktorTc.TabIndex = 20;
            // 
            // textBoxDoktorAdi
            // 
            this.textBoxDoktorAdi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxDoktorAdi.Location = new System.Drawing.Point(236, 196);
            this.textBoxDoktorAdi.Name = "textBoxDoktorAdi";
            this.textBoxDoktorAdi.Size = new System.Drawing.Size(270, 22);
            this.textBoxDoktorAdi.TabIndex = 19;
            // 
            // textBoxDoktorBransi
            // 
            this.textBoxDoktorBransi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxDoktorBransi.Location = new System.Drawing.Point(236, 299);
            this.textBoxDoktorBransi.Name = "textBoxDoktorBransi";
            this.textBoxDoktorBransi.Size = new System.Drawing.Size(270, 22);
            this.textBoxDoktorBransi.TabIndex = 18;
            // 
            // textBoxDoktorDogumYili
            // 
            this.textBoxDoktorDogumYili.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxDoktorDogumYili.Location = new System.Drawing.Point(236, 267);
            this.textBoxDoktorDogumYili.Name = "textBoxDoktorDogumYili";
            this.textBoxDoktorDogumYili.Size = new System.Drawing.Size(270, 22);
            this.textBoxDoktorDogumYili.TabIndex = 17;
            // 
            // textBoxDoktorSoyadi
            // 
            this.textBoxDoktorSoyadi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxDoktorSoyadi.Location = new System.Drawing.Point(236, 232);
            this.textBoxDoktorSoyadi.Name = "textBoxDoktorSoyadi";
            this.textBoxDoktorSoyadi.Size = new System.Drawing.Size(270, 22);
            this.textBoxDoktorSoyadi.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Doğum Yılı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(31, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Branşı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(31, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 19);
            this.label9.TabIndex = 12;
            this.label9.Tag = "";
            this.label9.Text = "Doktorun T.C No :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(31, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "Adı :";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // pnlIlac
            // 
            this.pnlIlac.Controls.Add(this.dataGridViewPersonelForm);
            this.pnlIlac.Controls.Add(this.button3);
            this.pnlIlac.Controls.Add(this.button2);
            this.pnlIlac.Controls.Add(this.button1);
            this.pnlIlac.Controls.Add(this.textBoxİlacAdi);
            this.pnlIlac.Controls.Add(this.textBoxİlacFiyati);
            this.pnlIlac.Controls.Add(this.label13);
            this.pnlIlac.Controls.Add(this.label14);
            this.pnlIlac.Location = new System.Drawing.Point(20, 136);
            this.pnlIlac.Name = "pnlIlac";
            this.pnlIlac.Size = new System.Drawing.Size(1067, 438);
            this.pnlIlac.TabIndex = 3;
            this.pnlIlac.Visible = false;
            // 
            // dataGridViewPersonelForm
            // 
            this.dataGridViewPersonelForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonelForm.Location = new System.Drawing.Point(553, 40);
            this.dataGridViewPersonelForm.Name = "dataGridViewPersonelForm";
            this.dataGridViewPersonelForm.RowTemplate.Height = 24;
            this.dataGridViewPersonelForm.Size = new System.Drawing.Size(398, 360);
            this.dataGridViewPersonelForm.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 50);
            this.button3.TabIndex = 22;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 51);
            this.button2.TabIndex = 21;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxİlacAdi
            // 
            this.textBoxİlacAdi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxİlacAdi.Location = new System.Drawing.Point(256, 79);
            this.textBoxİlacAdi.Name = "textBoxİlacAdi";
            this.textBoxİlacAdi.Size = new System.Drawing.Size(270, 22);
            this.textBoxİlacAdi.TabIndex = 20;
            // 
            // textBoxİlacFiyati
            // 
            this.textBoxİlacFiyati.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxİlacFiyati.Location = new System.Drawing.Point(256, 115);
            this.textBoxİlacFiyati.Name = "textBoxİlacFiyati";
            this.textBoxİlacFiyati.Size = new System.Drawing.Size(270, 22);
            this.textBoxİlacFiyati.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(51, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 12;
            this.label13.Tag = "";
            this.label13.Text = "İlaç Adı :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(51, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 22);
            this.label14.TabIndex = 11;
            this.label14.Text = "Fiyatı :";
            this.label14.UseCompatibleTextRendering = true;
            // 
            // FormPersonelGiris2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 647);
            this.Controls.Add(this.pnlIlac);
            this.Controls.Add(this.pnlHasta);
            this.Controls.Add(this.pnlDoktor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPersonelGiris2";
            this.Text = "FormPersonelGiris2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlHasta.ResumeLayout(false);
            this.pnlHasta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonelFormHasta)).EndInit();
            this.pnlDoktor.ResumeLayout(false);
            this.pnlDoktor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormPersonelDoktor)).EndInit();
            this.pnlIlac.ResumeLayout(false);
            this.pnlIlac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonelForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Panel pnlHasta;
        private System.Windows.Forms.TextBox textBoxHastaSosyalGuvence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHastaTc;
        private System.Windows.Forms.TextBox textBoxHastaAdi;
        private System.Windows.Forms.TextBox textBoxHastaAileHekimi;
        private System.Windows.Forms.TextBox textBoxHastaDogumYili;
        private System.Windows.Forms.TextBox textBoxHastaSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Panel pnlDoktor;
        private System.Windows.Forms.TextBox textBoxDoktorTc;
        private System.Windows.Forms.TextBox textBoxDoktorAdi;
        private System.Windows.Forms.TextBox textBoxDoktorBransi;
        private System.Windows.Forms.TextBox textBoxDoktorDogumYili;
        private System.Windows.Forms.TextBox textBoxDoktorSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlIlac;
        private System.Windows.Forms.TextBox textBoxİlacAdi;
        private System.Windows.Forms.TextBox textBoxİlacFiyati;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewPersonelFormHasta;
        private System.Windows.Forms.DataGridView dataGridViewFormPersonelDoktor;
        private System.Windows.Forms.DataGridView dataGridViewPersonelForm;
    }
}