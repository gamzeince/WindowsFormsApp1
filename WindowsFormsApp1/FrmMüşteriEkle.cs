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
    public partial class FrmMüşteriEkle : Form
    {
        Araç_Kiralama arac_kiralama = new Araç_Kiralama(); //eklediğimiz classa yeni bir isim veriyoruz

        public FrmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string cümle = "insert into müşteri_tb(Tc,Ad,Soyad,Yas,Telefon,Email,Adres) values (@Tc, @Ad, @Soyad, @Yas, @Telefon, @Email, @Adres )";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@Yas", txtYas.Text);
            komut2.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@Email", txtMail.Text);
            komut2.Parameters.AddWithValue("@Adres", txtAdres.Text);
            arac_kiralama.ekle_sil_güncelle(komut2, cümle);

            //texbox temizle
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";


        }
    }
}
