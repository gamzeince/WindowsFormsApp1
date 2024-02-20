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
     
    public partial class frmAraçListeleme : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        //private object SqlData;

        public frmAraçListeleme()
        {
            InitializeComponent();
        }

        private void frmAraçListeleme_Load(object sender, EventArgs e)
        {

            YenileAraçlarListele();
        }
        private void YenileAraçlarListele()
        {
            string cümle = "select * from araç_tb";

            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource =  arackiralama.listele(adtr2, cümle);
        }
       
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kayıtlar textlere geçsin
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtPlaka.Text = satır.Cells[0].Value.ToString();
            txtÜcret.Text = satır.Cells[1].Value.ToString();
            txtİndirimKodu.Text = satır.Cells[2].Value.ToString();
            txtSeri.Text = satır.Cells[3].Value.ToString();
            dateTimePicker1.MinDate.ToShortDateString();
            dateTimePicker2.MinDate.ToShortDateString();
           

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtPlaka.Text = satır.Cells["Plaka"].Value.ToString();
            comboBox2.Text = satır.Cells["Renk"].Value.ToString();
            txtÜcret.Text = satır.Cells["Ücret"].Value.ToString();
            txtDurum.Text = satır.Cells["Durum"].Value.ToString();
            comboBox1.Text = satır.Cells["Marka"].Value.ToString();
            comboBox3.Text = satır.Cells["Model"].Value.ToString();
            txtSeri.Text = satır.Cells["Seri"].Value.ToString();
            //txtPlaka.Text = satır.Cells["AlışTarihi"].Value.ToString();
            //txtPlaka.Text = satır.Cells["İadeTarihi"].Value.ToString();
            comboBox4.Text = satır.Cells["AlışOfisi"].Value.ToString();
            comboBox5.Text = satır.Cells["İadeOfisi"].Value.ToString();
            txtİndirimKodu.Text = satır.Cells["İndirimKodu"].Value.ToString();

        }

        private void grupAraç_Enter(object sender, EventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update araç_tb set  Renk=@Renk, Ücret=@Ücret, Durum=@Durum, Marka=@Marka, Model=@Model, Seri=@Seri, AlışTarihi=@AlışTarihi, İadeTarihi=@İadeTarihi, AlışOfisi=@AlışOfisi, İadeOfisi=@İadeOfisi,  where Plaka=@Plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Plaka",txtPlaka.Text);
            komut2.Parameters.AddWithValue("@Renk", comboBox2.Text);
            komut2.Parameters.AddWithValue("@Ücret", int.Parse(txtÜcret.Text));
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
            //komut2.Parameters.AddWithValue("@İndirimKodu", int.Parse(txtİndirimKodu.Text));

            arackiralama.ekle_sil_güncelle(komut2, cümle);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            //texbox temizle
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = " delete from araç_tb where Plaka= '" + satır.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            YenileAraçlarListele();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
