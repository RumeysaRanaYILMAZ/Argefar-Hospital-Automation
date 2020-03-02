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
    public partial class FormBabaAdiAl : Form
    {
        public FormBabaAdiAl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBabaAdiAlan.Text.Equals(""))
            {
                MessageBox.Show("Lütfen Aile Reisinin Adını Giriniz.");
            }
            else
            {
                
                this.Hide();
                
                HastahaneEntities he = new HastahaneEntities();
                var result = he.Hasta;
                Boolean girdi = false;
                String tc8 = "";
                foreach (var h in result)
                {
                    String a = h.H_Ad + " " + h.H_Soyad;
                    if (textBoxBabaAdiAlan.Text.Contains(a))
                    {
                        tc8 = h.Tcno.Substring(0, 8);
                        girdi = true;
                    }
                }
                if (girdi = false)
                {
                    MessageBox.Show("Böyle bir kayıt Bulunamadı!");
                }
                else
                {
                    var result2 = he.buldur(tc8);
                    foreach (var h in result2)
                    {
                        MessageBox.Show("Ailenizin Hastahane Gideri =" + h.ToString());
                    }
                }


            }

        }
    }
}
