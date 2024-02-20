using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient; //SQL  kütüphanesini referans olarak ekledik


namespace WindowsFormsApp1
{
    public partial class FrmMüşteriListeleme : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        private object SqlData;

        public FrmMüşteriListeleme()
        {
            InitializeComponent();
        }

        private void FrmMüşteriListeleme_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cümle = "select * from müşteri_tb";
            SqlDataAdapter adtr2 = new  SqlDataAdapter();
            
            txtTelefon.DataSource = arackiralama.listele(adtr2,cümle);
            txtTelefon.Columns[0].HeaderText = "TC";
            txtTelefon.Columns[1].HeaderText = "AD ";
            txtTelefon.Columns[2].HeaderText = "SOYAD";
            txtTelefon.Columns[3].HeaderText = "YAŞ";
            txtTelefon.Columns[4].HeaderText = "TELEFON";
            txtTelefon.Columns[4].HeaderText = "E-MAİL";
            txtTelefon.Columns[4].HeaderText = "ADRES";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //tc ile arama 
            string cümle = "select * from müşteri_tb where tc like '%"+textBox1.Text +"%' ";
            // % ifadesi tc nin basında sonunda ortasında varsa getirir 
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            
            
            txtTelefon.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //kayıtlar textlere geçsin
            DataGridViewRow satır = txtTelefon.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtAd.Text = satır.Cells[1].Value.ToString();
            txtSoyad.Text = satır.Cells[2].Value.ToString();
            txtYas.Text = satır.Cells[3].Value.ToString();
            txtTelefon.Text = satır.Cells[4].Value.ToString();
            txtMail.Text = satır.Cells[5].Value.ToString();
            txtAdres.Text = satır.Cells[6].Value.ToString();


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update müşteri_tb set Ad=@Ad, Soyad=@Soyad, Yas=@Yas, Telefon=@Telefon, Email=@Email, Adres=@Adres where Tc=@Tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@Yas", txtYas.Text);
            komut2.Parameters.AddWithValue("@Telefon", txtTel.Text);
            komut2.Parameters.AddWithValue("@Email", txtMail.Text);
            komut2.Parameters.AddWithValue("@Adres", txtAdres.Text);
            
            arackiralama.ekle_sil_güncelle(komut2, cümle);

            //texbox temizle
            //KONRTOL SINIFI VERİP TEXT TEMİZLİYORUM
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = txtTelefon.CurrentRow;
            //satır hücrelerini sil
            string cümle = "delete from müşteri_tb where tc= '" + satır.Cells["tc"].Value.ToString() + "' ";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            
           
            YenileListele();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
