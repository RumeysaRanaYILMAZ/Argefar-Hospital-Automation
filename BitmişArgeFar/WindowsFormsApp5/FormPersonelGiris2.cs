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
    public partial class FormPersonelGiris2 : Form
    {
        public FormPersonelGiris2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlHasta.Visible = true;
            pnlDoktor.Visible = false;
            pnlIlac.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pnlHasta.Visible = false;
            pnlDoktor.Visible = true;
            pnlIlac.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
        HastahaneEntities he = new HastahaneEntities();
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            pnlIlac.Visible = true;
            pnlHasta.Visible = false;
            pnlDoktor.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            he.Doktor.Add(new Doktor { D_Ad = textBoxDoktorAdi.Text, D_Soyad = textBoxDoktorSoyadi.Text, DogumYili = Convert.ToInt32(textBoxDoktorDogumYili.Text), Bransi = textBoxDoktorBransi.Text, Tcno = textBoxDoktorTc.Text });
            he.SaveChanges();
            dataGridViewFormPersonelDoktor.DataSource = he.Doktor.ToList();





        }

        private void button4_Click(object sender, EventArgs e)
        {
            he.Doktor.Remove(he.Doktor.First(d => d.Tcno.Contains(textBoxDoktorTc.Text)));
            he.SaveChanges();
            dataGridViewFormPersonelDoktor.DataSource = he.Doktor.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doktor d = he.Doktor.First(t => t.Tcno.Equals(textBoxDoktorTc.Text));


            d.Bransi = textBoxDoktorBransi.Text;
            d.DogumYili = Convert.ToInt32(textBoxDoktorDogumYili.Text);
            d.D_Ad = textBoxDoktorAdi.Text;
            d.D_Soyad = textBoxDoktorSoyadi.Text;


            he.SaveChanges();
            dataGridViewFormPersonelDoktor.DataSource = he.Doktor.ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            he.Hasta.Add(new Hasta { H_Ad = textBoxHastaAdi.Text, H_Soyad = textBoxHastaSoyadi.Text, DoğumYılı = Convert.ToInt32(textBoxHastaDogumYili.Text), AileHekimi = textBoxHastaAileHekimi.Text, SosyalGüvence = Convert.ToBoolean(textBoxHastaSosyalGuvence.Text), Tcno = textBoxHastaTc.Text });
            he.SaveChanges();
            dataGridViewPersonelFormHasta.DataSource = he.Hasta.ToList();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            he.Hasta.Remove(he.Hasta.First(d => d.Tcno.Contains(textBoxHastaTc.Text)));
            he.SaveChanges();
            dataGridViewPersonelFormHasta.DataSource = he.Hasta.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hasta d = he.Hasta.First(t => t.Tcno.Equals(textBoxHastaTc.Text));

            d.SosyalGüvence = Convert.ToBoolean(textBoxHastaSosyalGuvence.Text);
            d.H_Ad = textBoxHastaAdi.Text;
            d.H_Soyad = textBoxHastaSoyadi.Text;
            d.AileHekimi = textBoxHastaAileHekimi.Text;
            d.DoğumYılı = Convert.ToInt32(textBoxHastaDogumYili.Text);


            he.SaveChanges();
            dataGridViewPersonelFormHasta.DataSource = he.Hasta.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            he.İlaç.Add(new İlaç { İlaç_Adı = textBoxİlacAdi.Text, Fiyatı = Convert.ToDecimal(textBoxİlacFiyati.Text) });
            he.SaveChanges();
            dataGridViewPersonelForm.DataSource = he.İlaç.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            he.İlaç.Remove(he.İlaç.First(d => d.İlaç_Adı.Equals(textBoxİlacAdi.Text)));
            he.SaveChanges();
            dataGridViewPersonelForm.DataSource = he.İlaç.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İlaç d = he.İlaç.First(t => t.İlaç_Adı.Equals(textBoxİlacAdi.Text));

            d.Fiyatı = Convert.ToDecimal(textBoxİlacFiyati.Text);



            he.SaveChanges();
            dataGridViewPersonelForm.DataSource = he.İlaç.ToList();
        }
    }
}