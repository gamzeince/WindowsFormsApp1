using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class FormSözleşme : Form
    {
        public FormSözleşme()
        {
            InitializeComponent();
        }
        Araç_Kiralama arac = new Araç_Kiralama();
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void FormSözleşme_Load(object sender, EventArgs e)
        {
            Boş_Araçlar();
            Yenile();

        }

        private void Boş_Araçlar()
        {
            string sorgu2 = "select * from araç_tb where durum= 'BOŞ' ";
            arac.Boş_Araçlar(comboAraçlar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sözleşme_tb";

            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }








        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            //eğer boş olursa  grup box kpntrollerini tara 
            if (txtTc.Text == "") foreach (Control item in groupBox1.Controls)
                    //item is texbox ise temizle
                    if (item is TextBox) item.Text = "";
                         
            
            string sorgu2 = "select * from müşteri_tb where Tc like '" + txtTc.Text + "' ";
            arac.Tc_Ara(txtTc,  txtTelefon, sorgu2);


         

        }
       

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen değere göre gelicek
            string sorgu2 = "select * from araç_tb where plaka like  '" + comboAraçlar.SelectedItem + "' ";
            arac.CombodanGetir(comboAraçlar, txtMarka , txtSeri, txtRenk , sorgu2);
        }

        
        private void txtKiraŞekli_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sorgu2 = "select * from araç_tb where plaka like  '" + comboAraçlar.SelectedItem + "' ";
            arac.Ücret_Hesapla(combokiraşekli, txtKiraÜcreti, sorgu2);




           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDönüş.Text) - DateTime.Parse(dateÇıkış.Text);
            int gun2 = gun.Days;
            txtGün.Text = gun2.ToString();

            txtTutar.Text = (gun2 * int.Parse(txtKiraÜcreti.Text)).ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sözleşme_tb(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,ctarih,dtarih)  values (@tc, @adsoyad, @telefon, @ehliyetno, @e_tarih, @e_yer, @plaka, @marka, @seri, @yil, @renk, @kirasekli, @ctarih, @dtarih) ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
          

            komut2.Parameters.AddWithValue("@e_yer", txtE_Yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", comboAraçlar.Text);
            //komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
            //komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            //komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);


            arac.ekle_sil_güncelle(komut2, sorgu2);


            string sorgu3 = "update araç_tb set Durum='DOLU' where plaka='" + comboAraçlar.Text + " ' ";
            SqlCommand komut3 = new SqlCommand();
            arac.ekle_sil_güncelle(komut3, sorgu3);
            comboAraçlar.Items.Clear();
            Boş_Araçlar();
            Yenile(); // yenile metodunu çağırdık sözleşmeyi yenilemesi için
            foreach (Control item in groupBox1.Controls)
                //item is texbox ise temizle
                if (item is TextBox) item.Text = "";

            foreach (Control item in groupBox2.Controls)
                //item is texbox ise temizle
                if (item is TextBox) item.Text = "";

            MessageBox.Show("Sözleşme Eklendi");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
