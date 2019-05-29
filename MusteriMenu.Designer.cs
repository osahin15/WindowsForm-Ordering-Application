namespace SiparişOtomasyonProje
{
    partial class MusteriForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUrunAdGetir = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFiyatGetir = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboUrunler = new System.Windows.Forms.ComboBox();
            this.comboOdemeSekli = new System.Windows.Forms.ComboBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.listSepet = new System.Windows.Forms.ListBox();
            this.btnSepetEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSatınAl = new System.Windows.Forms.Button();
            this.btnSpTemizle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.btnMusteriKaydet);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAdı);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 322);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(179, 146);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(248, 113);
            this.txtAdres.TabIndex = 5;
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(179, 266);
            this.btnMusteriKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(249, 39);
            this.btnMusteriKaydet.TabIndex = 6;
            this.btnMusteriKaydet.Text = "Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(179, 106);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(148, 26);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(179, 58);
            this.txtAdı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(148, 26);
            this.txtAdı.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Soyadı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(693, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün Adı:";
            // 
            // lblUrunAdGetir
            // 
            this.lblUrunAdGetir.AutoSize = true;
            this.lblUrunAdGetir.Location = new System.Drawing.Point(926, 91);
            this.lblUrunAdGetir.Name = "lblUrunAdGetir";
            this.lblUrunAdGetir.Size = new System.Drawing.Size(27, 20);
            this.lblUrunAdGetir.TabIndex = 2;
            this.lblUrunAdGetir.Text = "__";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(62, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ödeme Şekli:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(693, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Adet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(56, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Toplam Tutar:";
            // 
            // lblFiyatGetir
            // 
            this.lblFiyatGetir.AutoSize = true;
            this.lblFiyatGetir.Location = new System.Drawing.Point(926, 136);
            this.lblFiyatGetir.Name = "lblFiyatGetir";
            this.lblFiyatGetir.Size = new System.Drawing.Size(27, 20);
            this.lblFiyatGetir.TabIndex = 6;
            this.lblFiyatGetir.Text = "__";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(693, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ürünler:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(693, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Fiyat:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(926, 184);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // comboUrunler
            // 
            this.comboUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUrunler.FormattingEnabled = true;
            this.comboUrunler.Location = new System.Drawing.Point(926, 30);
            this.comboUrunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboUrunler.Name = "comboUrunler";
            this.comboUrunler.Size = new System.Drawing.Size(136, 28);
            this.comboUrunler.TabIndex = 10;
            this.comboUrunler.SelectedIndexChanged += new System.EventHandler(this.comboUrunler_SelectedIndexChanged);
            // 
            // comboOdemeSekli
            // 
            this.comboOdemeSekli.FormattingEnabled = true;
            this.comboOdemeSekli.Items.AddRange(new object[] {
            "Banka Kartı",
            "Kredi Kartı",
            "Nakit"});
            this.comboOdemeSekli.Location = new System.Drawing.Point(249, 386);
            this.comboOdemeSekli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboOdemeSekli.Name = "comboOdemeSekli";
            this.comboOdemeSekli.Size = new System.Drawing.Size(260, 28);
            this.comboOdemeSekli.TabIndex = 11;
            this.comboOdemeSekli.Text = "Seçiniz...";
            this.comboOdemeSekli.SelectedIndexChanged += new System.EventHandler(this.comboOdemeSekli_SelectedIndexChanged);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(249, 501);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(260, 26);
            this.txtToplamTutar.TabIndex = 12;
            this.txtToplamTutar.Text = "0";
            // 
            // listSepet
            // 
            this.listSepet.FormattingEnabled = true;
            this.listSepet.ItemHeight = 20;
            this.listSepet.Location = new System.Drawing.Point(564, 334);
            this.listSepet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listSepet.Name = "listSepet";
            this.listSepet.Size = new System.Drawing.Size(541, 244);
            this.listSepet.TabIndex = 13;
            // 
            // btnSepetEkle
            // 
            this.btnSepetEkle.Location = new System.Drawing.Point(564, 246);
            this.btnSepetEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSepetEkle.Name = "btnSepetEkle";
            this.btnSepetEkle.Size = new System.Drawing.Size(541, 55);
            this.btnSepetEkle.TabIndex = 14;
            this.btnSepetEkle.Text = "Sepete Ekle";
            this.btnSepetEkle.UseVisualStyleBackColor = true;
            this.btnSepetEkle.Click += new System.EventHandler(this.btnSepetEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SiparişOtomasyonProje.Properties.Resources.visa_mastercard_logo;
            this.pictureBox1.Location = new System.Drawing.Point(249, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSatınAl
            // 
            this.btnSatınAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatınAl.Location = new System.Drawing.Point(12, 551);
            this.btnSatınAl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSatınAl.Name = "btnSatınAl";
            this.btnSatınAl.Size = new System.Drawing.Size(541, 55);
            this.btnSatınAl.TabIndex = 16;
            this.btnSatınAl.Text = "Satın Al";
            this.btnSatınAl.UseVisualStyleBackColor = true;
            this.btnSatınAl.Click += new System.EventHandler(this.btnSatınAl_Click);
            // 
            // btnSpTemizle
            // 
            this.btnSpTemizle.Location = new System.Drawing.Point(564, 598);
            this.btnSpTemizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSpTemizle.Name = "btnSpTemizle";
            this.btnSpTemizle.Size = new System.Drawing.Size(541, 55);
            this.btnSpTemizle.TabIndex = 18;
            this.btnSpTemizle.Text = "Sepet Temizle";
            this.btnSpTemizle.UseVisualStyleBackColor = true;
            this.btnSpTemizle.Click += new System.EventHandler(this.btnSpTemizle_Click);
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 709);
            this.Controls.Add(this.btnSpTemizle);
            this.Controls.Add(this.btnSatınAl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSepetEkle);
            this.Controls.Add(this.listSepet);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.comboOdemeSekli);
            this.Controls.Add(this.comboUrunler);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblFiyatGetir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUrunAdGetir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MusteriForm";
            this.Text = "MusteriMenu";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusteriKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUrunAdGetir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFiyatGetir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboOdemeSekli;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.ListBox listSepet;
        private System.Windows.Forms.Button btnSepetEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSatınAl;
        private System.Windows.Forms.Button btnSpTemizle;
        public System.Windows.Forms.ComboBox comboUrunler;
        public System.Windows.Forms.TextBox txtAdı;
    }
}