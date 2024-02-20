using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); //çıkış komutu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMüşteriEkle ekle = new FrmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //formlar arası geçiş
            FrmMüşteriListeleme listele = new FrmMüşteriListeleme();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            frmAraçKayıt araçKayıt = new frmAraçKayıt();
            araçKayıt.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAraçListeleme listele = new frmAraçListeleme();
            listele.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSözleşme sözleşme = new FormSözleşme();
            sözleşme.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
