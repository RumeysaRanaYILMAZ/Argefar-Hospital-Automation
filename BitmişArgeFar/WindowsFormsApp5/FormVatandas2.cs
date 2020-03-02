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
    public partial class FormVatandas2 : Form
    {
        public FormVatandas2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBilgileriGoruntue frm = new FormBilgileriGoruntue();
            frm.labelGorunmez.Text = lblVatandasTC2.Text;
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGrs frm = new FrmGrs();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRandevuAl randevu = new FormRandevuAl();
            randevu.Show();

        }
    }
}
