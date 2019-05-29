using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.IO;

namespace SiparişOtomasyonProje
{
    public partial class KullaniciForm : Form
    {
        public int no = 1;
        public static Market Katolog = new Market();
        public static List<Musteri> MusterilerList = new List<Musteri>();
        public KullaniciForm()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (panelUrunEkle.Visible == false)
                panelUrunEkle.Visible = true;

            txtStok.Clear();
            txtFiyat.Clear();
            txtUrunAdi.Clear();
            txtUrunKodu.Clear();

            btnKaydet.Text = "Kaydet";
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (panelUrunEkle.Visible == false)   //Listede seçilen ürünü güncelleme butonu.
                panelUrunEkle.Visible = true;

            btnKaydet.Text = "Güncelle";

            int sayac = 0;

            foreach (Urun u in Katolog.Urunler)
            {
                if(sayac==listUrunler.SelectedIndex) //Seçilen ürün degerlerini textboxlara getirir 
                {
                    txtUrunAdi.Text = u.UrunAdi;              
                    txtUrunKodu.Text = u.UrunKodu.ToString();
                    txtStok.Text = u.Stok.ToString();
                    txtFiyat.Text = u.Fiyat.ToString();
                }
                sayac++;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnKaydet.Text=="Kaydet")
                {
                    Urun u1 = new Urun();

                    u1.UrunAdi = txtUrunAdi.Text;
                    u1.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
                    u1.Stok = Convert.ToInt32(txtStok.Text);
                    u1.Fiyat = Convert.ToInt32(txtFiyat.Text);

                    listUrunler.Items.Add(u1.UrunBilgiGoster());//Girilen ürünleri Listeler.
                    KullaniciForm.Katolog.Urunler.Add(u1);

                    StreamWriter urunlerkayit = File.AppendText("urunlerkayit.txt");//Girilen ürünleri txt e kaydeder.
                    urunlerkayit.Write(txtUrunAdi.Text+"-");
                    urunlerkayit.Write(txtUrunKodu.Text+"-");
                    urunlerkayit.Write(txtStok.Text+"-");
                    urunlerkayit.Write(txtFiyat.Text+Environment.NewLine);

                    urunlerkayit.Close();


                    txtUrunAdi.Clear();
                    txtFiyat.Clear();
                    txtStok.Clear();
                    txtUrunKodu.Clear();
                    txtUrunAdi.Focus();

                }
                else
                {
                    //Listedeki Seçilen ürüne yeni deger atar.

                    int sayac = listUrunler.SelectedIndex;
                    Urun u2 = new Urun();
                    u2.UrunAdi = txtUrunAdi.Text;
                    u2.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
                    u2.Stok = Convert.ToInt32(txtStok.Text);
                    u2.Fiyat = Convert.ToInt32(txtFiyat.Text);

                    listUrunler.Items.RemoveAt(sayac);
                    KullaniciForm.Katolog.Urunler.RemoveAt(sayac);

                    listUrunler.Items.Insert(sayac, u2.UrunBilgiGoster());
                    KullaniciForm.Katolog.Urunler.Insert(sayac, u2);

                    txtUrunAdi.Clear();
                    txtUrunKodu.Clear();
                    txtStok.Clear();
                    txtFiyat.Clear();
                 }
            }
            catch (Exception ex)
            {
                if (btnKaydet.Text == "Kaydet")
                    MessageBox.Show("Giriş Yapın");
                else
                    MessageBox.Show("Seçim Yapın");

                throw;
            }
        }

        private void btnUrunCikar_Click(object sender, EventArgs e)
        {
            listUrunler.Items.RemoveAt(listUrunler.SelectedIndex);

            txtStok.Clear();
            txtFiyat.Clear();
            txtUrunAdi.Clear();
            txtUrunKodu.Clear();
        }
        public void StokGuncelle()
        {
            listUrunler.Items.Clear();
            foreach (Urun urun in KullaniciForm.Katolog.Urunler)
            {
                listUrunler.Items.Add(urun.UrunBilgiGoster());
                txtStok.Clear();
                txtFiyat.Clear();
                txtUrunAdi.Clear();
                txtUrunKodu.Clear();
            }
        }

        private void listGelenMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {

            StreamReader musteriliste = File.OpenText("musterikayit.txt");

            while (musteriliste.Peek()!=-1)
            {
                listGelenMusteriler.Items.Add(musteriliste.ReadLine());

            }

        }
    }
}
