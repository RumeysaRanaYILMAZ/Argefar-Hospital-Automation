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
    public partial class FrmGrs : Form
    {
        public FrmGrs()
        {
            InitializeComponent();
        }
        public String TCPublic  = "";
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FormPersonelGiris frm = new FormPersonelGiris();
            frm.Show();
            this.Enabled = false;
        }

        private void btnVatandas_Click(object sender, EventArgs e)
        {
            FormVatandas frm = new FormVatandas();
            frm.Show();
            this.Enabled = false;
        }
    }
}
