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
    public partial class FormVatandas : Form
    {
        public FormVatandas()
        {
            InitializeComponent();
        }
        HastahaneEntities he = new HastahaneEntities();
        private void btnVtndsGrs_Click(object sender, EventArgs e)
        {
            var result = he.Hasta;
            Boolean girdi = false;
            foreach(var h in result)
            {

               if(textBoxVatandasTCGiris.Text.Equals(h.Tcno))
                {
                    FormVatandas2 vtnds = new FormVatandas2();
                    vtnds.lblVatandasAd2.Text = h.H_Ad;
                    vtnds.lblVatandasBrans2.Text = h.AileHekimi;
                    vtnds.lblVatandasDogumTarihi2.Text = h.DoğumYılı.ToString();
                    vtnds.lblVatandasSosyalGuvence.Text = h.SosyalGüvence.ToString();
                    vtnds.lblVatandasSoyad2.Text = h.H_Soyad;
                    vtnds.lblVatandasTC2.Text = h.Tcno;

                    this.Visible = false;
                    

                    vtnds.Show();
                    girdi = true;
                    

                }
            }
            if(girdi==false)
            {
                label2.Text = "Kayıt Bulunamadı!!";
            }

            
        }
    }
}
