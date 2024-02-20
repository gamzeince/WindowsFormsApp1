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
    public partial class frmAraçKayıt : Form
    {
        
        Araç_Kiralama arackiralama = new Araç_Kiralama(); //eklediğimiz classa yeni bir isim veriyoruz

        public frmAraçKayıt()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grupAraç_Enter(object sender, EventArgs e)
        {

        }

        private void frmAraçKayıt_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string cümle = "insert into araç_tb(Plaka,Renk,Ücret,Durum,Marka,Model,Seri,AlışTarihi,İadeTarihi,AlışOfisi,İadeOfisi,İndirimKodu) values (@Plaka, @Renk, @Ücret, @Durum, @Marka, @Model, @Seri, @AlışTarihi, @İadeTarihi, @AlışOfisi, @İadeOfisi, @İndirimKodu)";
            SqlCommand komut2 = new SqlCommand();
            //komut2.Parameters.AddWithValue("@id", txtTc.Text);
            komut2.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut2.Parameters.AddWithValue("@Renk", comboBox2.Text);
            komut2.Parameters.AddWithValue("@Ücret",txtÜcret.Text);
            komut2.Parameters.AddWithValue("@Durum", txtDurum.Text);
            komut2.Parameters.AddWithValue("@Marka", comboBox1.Text);
            
            komut2.Parameters.AddWithValue("@Model", comboBox3.Text);
            komut2.Parameters.AddWithValue("@Seri", txtSeri.Text);
            //komut2.Parameters.AddWithValue("@AlışTarihi", dateTimePicker1.Text);
            komut2.Parameters.AddWithValue("@AlışTarihi", dateTimePicker1.MinDate.ToShortDateString());
            //komut2.Parameters.AddWithValue("@İadeTarihi", dateTimePicker2.Text);
            komut2.Parameters.AddWithValue("@İadeTarihi", dateTimePicker2.MinDate.ToShortDateString());
            komut2.Parameters.AddWithValue("@AlışOfisi", comboBox4.Text);
            komut2.Parameters.AddWithValue("@İadeOfisi", comboBox5.Text);
            komut2.Parameters.AddWithValue("@İndirimKodu",txtİndirimKodu.Text);

            arackiralama.ekle_sil_güncelle(komut2, cümle);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            //texbox temizle
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            //foreach (Control item in Controls) if (item is ComboBox) item.Text = "";



        }
    }
}
