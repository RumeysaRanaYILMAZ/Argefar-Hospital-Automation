namespace WindowsFormsApp5
{
    partial class FrmGrs
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVatandas = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVatandas
            // 
            this.btnVatandas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVatandas.Location = new System.Drawing.Point(72, 84);
            this.btnVatandas.Name = "btnVatandas";
            this.btnVatandas.Size = new System.Drawing.Size(228, 89);
            this.btnVatandas.TabIndex = 0;
            this.btnVatandas.Text = "Vatandaş";
            this.btnVatandas.UseVisualStyleBackColor = true;
            this.btnVatandas.Click += new System.EventHandler(this.btnVatandas_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.Location = new System.Drawing.Point(357, 84);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(227, 89);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // FrmGrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 243);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnVatandas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGrs";
            this.Text = "Hastahane Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVatandas;
        private System.Windows.Forms.Button btnPersonel;
    }
}

