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
    public partial class FormMuayenGuncelle : Form
    {
        public FormMuayenGuncelle()
        {
            InitializeComponent();
        }
        HastahaneEntities te = new HastahaneEntities();
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void FormMuayenGuncelle_Load(object sender, EventArgs e)
        {
            var result = te.MuayeneDoktor(labelGorunmezDoktor.Text);
            foreach(var h in result)
            {
                
                comboBox1.Items.Add(h.TCno);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Muayene m = te.Muayene.First(d => d.TCno == comboBox1.Text);

            //m.Tarih = dateTimePicker1.Value;
            m.Doktoru = textBoxMuayeneGuncelleDoktorTc.Text;
            m.Branşı = textBoxMuayeneGuncelleBrans.Text;
            m.İlac = textBoxMuayeneGuncelleIlac.Text;

            te.SaveChanges();
           
           
            
            this.Hide();

        }
    }
}
