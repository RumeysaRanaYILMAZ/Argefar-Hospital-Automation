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
    public partial class FormRandevuAl : Form
    {
        public FormRandevuAl()
        {
            InitializeComponent();

        }

        HastahaneEntities he = new HastahaneEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            he.Muayene.Add(new Muayene { Tarih = dateTimePicker1.Value,TCno=textBoxRandevuHastaTc.Text,Doktoru=textBoxRandevuDoktorTc.Text,Branşı=textBoxRandevuBrans.Text});
            he.SaveChanges();
            MessageBox.Show("Başarıyla Randevu Aldınız!!");
            

            this.Hide();

        }
    }
}
