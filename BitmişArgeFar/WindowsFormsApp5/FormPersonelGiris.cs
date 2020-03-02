using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FormPersonelGiris : Form
    {
        public FormPersonelGiris()
        {
            InitializeComponent();
        }

        private void rdbtnPersonel_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDoktor.Visible = false;
            groupBoxPersonel.Visible = true;
        }

        private void rdbtnDoktor_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDoktor.Visible = true;
            groupBoxPersonel.Visible = false;
        }
        HastahaneEntities he = new HastahaneEntities();
        private void btnDktrGrs_Click(object sender, EventArgs e)
        {
            
            var result = he.Doktor;
            Boolean girdi = false;
            foreach (var h in result)
            {

                if (textBoxDoktorTcAl.Text.Equals(h.Tcno))
                {
                    FormDoktor frm = new FormDoktor();
                    frm.lblDoktorAd2.Text = h.D_Ad;
                    frm.lblDoktorBrans2.Text = h.Bransi;
                    frm.lblDoktorSoyad2.Text = h.D_Soyad;
                    frm.lblDoktorDogumTarihi2.Text = h.DogumYili.ToString();
                    frm.lblDoktorTC2.Text = h.Tcno;

                    this.Visible = false;
                    frm.Show();
                }
            }
            if (girdi == false)
            {
                label2.Text = "Kayıt Bulunamadı!!";
            }

           
        }

        private void FormPersonelGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnPrsnlGrs_Click(object sender, EventArgs e)
        {
            FormPersonelGiris2 prsnl = new FormPersonelGiris2();
            this.Hide();
            prsnl.Show();

        }

        private void groupBoxPersonel_Enter(object sender, EventArgs e)
        {

        }
    }
}
