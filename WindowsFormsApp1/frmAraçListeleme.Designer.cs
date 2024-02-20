namespace WindowsFormsApp1
{
    partial class frmAraçListeleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupAraç = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.txtİndirimKodu = new System.Windows.Forms.TextBox();
            this.txtÜcret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupAraç.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupAraç
            // 
            this.grupAraç.Controls.Add(this.dataGridView1);
            this.grupAraç.Controls.Add(this.btnSil);
            this.grupAraç.Controls.Add(this.btnGüncelle);
            this.grupAraç.Controls.Add(this.comboBox5);
            this.grupAraç.Controls.Add(this.comboBox4);
            this.grupAraç.Controls.Add(this.dateTimePicker2);
            this.grupAraç.Controls.Add(this.dateTimePicker1);
            this.grupAraç.Controls.Add(this.comboBox2);
            this.grupAraç.Controls.Add(this.txtSeri);
            this.grupAraç.Controls.Add(this.txtDurum);
            this.grupAraç.Controls.Add(this.txtİndirimKodu);
            this.grupAraç.Controls.Add(this.txtÜcret);
            this.grupAraç.Controls.Add(this.label7);
            this.grupAraç.Controls.Add(this.label9);
            this.grupAraç.Controls.Add(this.label12);
            this.grupAraç.Controls.Add(this.label11);
            this.grupAraç.Controls.Add(this.label10);
            this.grupAraç.Controls.Add(this.label8);
            this.grupAraç.Controls.Add(this.label6);
            this.grupAraç.Controls.Add(this.comboBox3);
            this.grupAraç.Controls.Add(this.txtPlaka);
            this.grupAraç.Controls.Add(this.comboBox1);
            this.grupAraç.Controls.Add(this.label5);
            this.grupAraç.Controls.Add(this.label4);
            this.grupAraç.Controls.Add(this.label3);
            this.grupAraç.Controls.Add(this.label2);
            this.grupAraç.Controls.Add(this.label1);
            this.grupAraç.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupAraç.Location = new System.Drawing.Point(8, 4);
            this.grupAraç.Name = "grupAraç";
            this.grupAraç.Size = new System.Drawing.Size(780, 434);
            this.grupAraç.TabIndex = 1;
            this.grupAraç.TabStop = false;
            this.grupAraç.Text = "Araç Listesi";
            this.grupAraç.Enter += new System.EventHandler(this.grupAraç_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(41, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(682, 104);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 44);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.Red;
            this.btnGüncelle.Location = new System.Drawing.Point(682, 39);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(92, 43);
            this.btnGüncelle.TabIndex = 19;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "dailydrive Rent a Car Maltepe",
            "Budget İstanbul",
            "Avis Genel Müdürlük",
            "Kartal Üsmen Oto Kiralama",
            "Maltepe Araç Kiralama",
            "Enterprise Rent A Car",
            "Avis Ataşehır",
            "Hertz Rent A Car",
            "Eroğlu Rent A Car",
            "RENT A CAR",
            "Atalar Rent A Car"});
            this.comboBox5.Location = new System.Drawing.Point(477, 134);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(104, 24);
            this.comboBox5.TabIndex = 16;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Avis Genel Müdürlük",
            "dailydrive Rent a Car",
            "Budget İstanbul",
            "Maltepe Araç Kiralama",
            "Hertz Rent A Car",
            "Dollar Car Rental",
            "Popy Rent a Car - BuYaka Ofisi",
            "Europcar Taksim Ofis",
            "Happy Rent A Car İstanbul",
            "Narfilo Araç Kiralama A.Ş.,",
            "TANRIVERDİ RENT A CAR"});
            this.comboBox4.Location = new System.Drawing.Point(477, 97);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(104, 24);
            this.comboBox4.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(477, 210);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 24);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 24);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Beyaz",
            "Siyah",
            "Kırmızı",
            "Lacivert",
            "Gri",
            "Gümüş ",
            "Mavi ",
            "Kahve ",
            "Diğer Renkler"});
            this.comboBox2.Location = new System.Drawing.Point(477, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(194, 131);
            this.txtSeri.Multiline = true;
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(92, 31);
            this.txtSeri.TabIndex = 11;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(194, 171);
            this.txtDurum.Multiline = true;
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(92, 26);
            this.txtDurum.TabIndex = 9;
            // 
            // txtİndirimKodu
            // 
            this.txtİndirimKodu.Location = new System.Drawing.Point(194, 97);
            this.txtİndirimKodu.Multiline = true;
            this.txtİndirimKodu.Name = "txtİndirimKodu";
            this.txtİndirimKodu.Size = new System.Drawing.Size(92, 24);
            this.txtİndirimKodu.TabIndex = 8;
            // 
            // txtÜcret
            // 
            this.txtÜcret.Location = new System.Drawing.Point(194, 60);
            this.txtÜcret.Multiline = true;
            this.txtÜcret.Name = "txtÜcret";
            this.txtÜcret.Size = new System.Drawing.Size(92, 22);
            this.txtÜcret.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Durum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "İade Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "İndirim Kodu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "İade Ofisi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Alış Ofisi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Alış Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ücret";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Alfa Romeo MiTo",
            "Audi TT",
            "Chevrolet Camaro",
            "Ferrari GTC4Lusso",
            "Fiat 500",
            "Mercedes800",
            "Bmw i2",
            "Lamborghini",
            "Tesla",
            "Toyota Yaris"});
            this.comboBox3.Location = new System.Drawing.Point(477, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(104, 24);
            this.comboBox3.TabIndex = 5;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(194, 21);
            this.txtPlaka.Multiline = true;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(92, 24);
            this.txtPlaka.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alfa Romeo",
            " BMW",
            "Audi",
            "Bentley",
            "Bugatti",
            "Hondo",
            "Toyota",
            "Opel",
            "Lada",
            "Dodge",
            "Mini",
            "Mercedes",
            "Mazda",
            "Volvo",
            "Tata"});
            this.comboBox1.Location = new System.Drawing.Point(194, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // frmAraçListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupAraç);
            this.Name = "frmAraçListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme";
            this.Load += new System.EventHandler(this.frmAraçListeleme_Load);
            this.grupAraç.ResumeLayout(false);
            this.grupAraç.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupAraç;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.TextBox txtİndirimKodu;
        private System.Windows.Forms.TextBox txtÜcret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}