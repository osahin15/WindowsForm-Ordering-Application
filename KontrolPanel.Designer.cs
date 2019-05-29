namespace SiparişOtomasyonProje
{
    partial class KullaniciForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listUrunler = new System.Windows.Forms.ListBox();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunCikar = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.panelUrunEkle = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listGelenMusteriler = new System.Windows.Forms.ListBox();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelUrunEkle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listUrunler);
            this.tabPage1.Controls.Add(this.btnUrunGuncelle);
            this.tabPage1.Controls.Add(this.btnUrunCikar);
            this.tabPage1.Controls.Add(this.btnUrunEkle);
            this.tabPage1.Controls.Add(this.panelUrunEkle);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(615, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listUrunler
            // 
            this.listUrunler.FormattingEnabled = true;
            this.listUrunler.ItemHeight = 20;
            this.listUrunler.Location = new System.Drawing.Point(54, 364);
            this.listUrunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listUrunler.Name = "listUrunler";
            this.listUrunler.Size = new System.Drawing.Size(422, 204);
            this.listUrunler.TabIndex = 5;
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(381, 310);
            this.btnUrunGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(96, 46);
            this.btnUrunGuncelle.TabIndex = 4;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunCikar
            // 
            this.btnUrunCikar.Location = new System.Drawing.Point(210, 310);
            this.btnUrunCikar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUrunCikar.Name = "btnUrunCikar";
            this.btnUrunCikar.Size = new System.Drawing.Size(101, 46);
            this.btnUrunCikar.TabIndex = 3;
            this.btnUrunCikar.Text = "Ürün Çıkar";
            this.btnUrunCikar.UseVisualStyleBackColor = true;
            this.btnUrunCikar.Click += new System.EventHandler(this.btnUrunCikar_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(54, 310);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(97, 46);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // panelUrunEkle
            // 
            this.panelUrunEkle.Controls.Add(this.btnKaydet);
            this.panelUrunEkle.Controls.Add(this.txtStok);
            this.panelUrunEkle.Controls.Add(this.txtFiyat);
            this.panelUrunEkle.Controls.Add(this.txtUrunKodu);
            this.panelUrunEkle.Controls.Add(this.txtUrunAdi);
            this.panelUrunEkle.Controls.Add(this.label4);
            this.panelUrunEkle.Controls.Add(this.label3);
            this.panelUrunEkle.Controls.Add(this.label2);
            this.panelUrunEkle.Controls.Add(this.label1);
            this.panelUrunEkle.Location = new System.Drawing.Point(54, 31);
            this.panelUrunEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUrunEkle.Name = "panelUrunEkle";
            this.panelUrunEkle.Size = new System.Drawing.Size(423, 235);
            this.panelUrunEkle.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(156, 169);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 44);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(156, 134);
            this.txtStok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(139, 26);
            this.txtStok.TabIndex = 7;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(156, 99);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(139, 26);
            this.txtFiyat.TabIndex = 6;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(156, 64);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(139, 26);
            this.txtUrunKodu.TabIndex = 5;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(156, 29);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(139, 26);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Kodu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMusteriListele);
            this.tabPage2.Controls.Add(this.listGelenMusteriler);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(615, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri Takip";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listGelenMusteriler
            // 
            this.listGelenMusteriler.FormattingEnabled = true;
            this.listGelenMusteriler.ItemHeight = 20;
            this.listGelenMusteriler.Location = new System.Drawing.Point(8, 172);
            this.listGelenMusteriler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listGelenMusteriler.Name = "listGelenMusteriler";
            this.listGelenMusteriler.Size = new System.Drawing.Size(590, 364);
            this.listGelenMusteriler.TabIndex = 0;
            this.listGelenMusteriler.SelectedIndexChanged += new System.EventHandler(this.listGelenMusteriler_SelectedIndexChanged);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(81, 50);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(403, 74);
            this.btnMusteriListele.TabIndex = 1;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // KullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 732);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KullaniciForm";
            this.Text = "KontrolPanel";
            this.Load += new System.EventHandler(this.KullaniciForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelUrunEkle.ResumeLayout(false);
            this.panelUrunEkle.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listUrunler;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunCikar;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Panel panelUrunEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listGelenMusteriler;
        private System.Windows.Forms.Button btnMusteriListele;
    }
}