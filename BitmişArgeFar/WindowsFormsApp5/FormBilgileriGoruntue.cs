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
    public partial class FormBilgileriGoruntue : Form
    {
        public FormBilgileriGoruntue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            HastahaneEntities he =new HastahaneEntities();
            if (checkBoxAileYillik.Checked == true)
            {
                FormBabaAdiAl baba = new FormBabaAdiAl();
                baba.Show();
                
          

            }
            if (checkBoxBireyselYillik.Checked == true)
            {

                var result = he.gider(labelGorunmez.Text);
                foreach (var t in result)
                {
                    MessageBox.Show("Bireysel Sağlık Gideriniz"+t.ToString());
                }
                
               
                

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
