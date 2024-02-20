using System;
using System.Collections.Generic;
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
    class Araç_Kiralama
    {
        // public string user_id;


        SqlConnection baglanti = new SqlConnection("Data Source=GAMZE;Initial Catalog=Araç_Kiralama;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        DataTable tablo;

        //metot oluşturuyoruz
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu; // sorgudan alınacak
            komut.ExecuteNonQuery(); //işlemi onaylama
            baglanti.Close();
        }

        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            //kayıtlar güncel haliyle tablo içerisinde gelecektir
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);


            return tablo;
        }

        public void Boş_Araçlar(ComboBox combo, string sorgu)  //metot oluşturuldu
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) //readler okunduğu sürece bu döngü kullanılsın
            {
                combo.Items.Add(read["Plaka"].ToString()); //databas plakası boş olanı gösterir
            }
            baglanti.Close();
        }


        public void Tc_Ara(TextBox tc, TextBox telefon, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) //readler okunduğu sürece bu döngü kullanılsın
            {
                //adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
                
            }
            baglanti.Close();
        }


        
        public void Ücret_Hesapla(ComboBox combokiraşekli , TextBox ucret,  string sorgu )
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) //readler okunduğu sürece bu döngü kullanılsın
            {
                if (combokiraşekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                if (combokiraşekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.80).ToString();
                if (combokiraşekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.70).ToString();

            }
            baglanti.Close();
        }
        
        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri,   TextBox renk , string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) //readler okunduğu sürece bu döngü kullanılsın
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                //yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();

            }
            baglanti.Close();
        }


        //ARAÇ KİRALAMA İÇİN
        /*
         public DataTable liste(SqlDataAdapter adtrr, string sorgu)
        {
            
        }
        
        */

    }
}
