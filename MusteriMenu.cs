using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace SiparişOtomasyonProje
{
    public partial class MusteriForm : Form
    {
      public  static Market m=new Market();
        
        public int sayac,sepetsayac;
        public int no = 1;
        public  int tektutar = 0;
        public int sepetTutar = 0, SepetAdet=0;



        public MusteriForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
           StreamReader urunliste=new StreamReader("urunlerkayit.txt");

            sayac = -1;
            int i = 1;

            string y=urunliste.ReadLine();
            //Urunlerkayit.txt den Urunadı Label,Fiyat lbl ve Numeric e txt den veri çeker. 
            while (comboUrunler.SelectedIndex!=sayac)  
            {
                    string[] x = y.Split('-');
                    lblUrunAdGetir.Text = x[0];
                    lblFiyatGetir.Text = x[3];
                    numericUpDown1.Maximum = Convert.ToInt32(x[2]);
                    numericUpDown1.Minimum = 1;
                    y = urunliste.ReadLine();

                    sayac++;

            }

        }

        


        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {

            if (txtAdı.Text!=""&&txtSoyad.Text!=""&&txtAdres.Text!="")
            {
                Musteri m=new Musteri();
                m.Ad = txtAdı.Text;
                m.Soyad = txtSoyad.Text;
                m.Adres = txtAdres.Text;
                m.MusteriNo = no;
                no++;
                KullaniciForm.Katolog.Musteriler.Add(m);

                StreamWriter musterikayit = File.AppendText("musterikayit.txt");//musterikayit.txt yazar.
                
                musterikayit.Write(txtAdı.Text+"-");
                musterikayit.Write(txtSoyad.Text+"-");
                musterikayit.Write(txtAdres.Text+Environment.NewLine);

                musterikayit.Close();
                txtAdı.Focus();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!!!");
            }
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            //Musteri formu acıldığında urunlerkayit.txt açılır.
            StreamReader urunlistele = File.OpenText("urunlerkayit.txt");

            string line = urunlistele.ReadLine();

            while (line!=null)
            {

                string[] x = line.Split('-');
                comboUrunler.Items.Add(x[0]);     //urunlerkayit.txt deki Ürün isimlerini combobox a ekler.
                line = urunlistele.ReadLine();    
            }


            

           

        }

        private void btnSepetEkle_Click(object sender, EventArgs e)
        {

          


            try
            {
                if (comboUrunler.SelectedText!="Seçiniz...")
                {
                    listSepet.Items.Add("Ürün Adı:" + lblUrunAdGetir.Text + "Ürün Adet:" + numericUpDown1.Value +
                                        "Ürün Fiyat:" + Convert.ToInt32(lblFiyatGetir.Text) + "Tutar:" +
                                        Convert.ToInt32(lblFiyatGetir.Text) * numericUpDown1.Value+"TL"+Environment.NewLine);

                   


                }
                //Toplam Tutar Hesaplama
                SepetAdet = Convert.ToInt32(numericUpDown1.Value);

                tektutar = SepetAdet * Convert.ToInt32(lblFiyatGetir.Text);

                sepetTutar += tektutar;

                txtToplamTutar.Text = sepetTutar.ToString();

                numericUpDown1.Maximum = numericUpDown1.Maximum -Convert.ToInt32(numericUpDown1.Value);

                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Seçiniz...");

            }

        }

        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            Musteri m1=new Musteri();
            m1.Ad = txtAdı.Text;
            m1.Adres = txtAdres.Text;

            Siparis s=new Siparis();
            s.SiparisTarihi=DateTime.Now;
            s.SiparisDurum = "Siparişiniz oluşturuldu.";

            try
            {

                if (comboUrunler.SelectedIndex!=-1&&comboOdemeSekli.SelectedIndex!=-1)
                {

                    MessageBox.Show("Sanal Market'e Hoş Geldiniz.." + Environment.NewLine + "Tarih:" + s.SiparisTarihi +
                                    Environment.NewLine +
                                    "Sipariş Durumu:" + s.SiparisDurum + Environment.NewLine + "Musteri Adı:" +
                                    m1.Ad + Environment.NewLine +"Adres:"+m1.Adres+Environment.NewLine+ "Toplam Tutar:" + txtToplamTutar.Text +Environment.NewLine+"Odeme Tipi:"+comboOdemeSekli.Text+
                                    Environment.NewLine + "Yine Bekleriz..");

                }



            }
            catch (Exception exception)
            {

                MessageBox.Show("Ürün Seçmediniz..");


            }



        }

        private void comboOdemeSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOdemeSekli.SelectedIndex==0)
            {
                BankaKarti frm1=new BankaKarti();
                frm1.ShowDialog();


            }

            if (comboOdemeSekli.SelectedIndex==1)
            {
                KrediKartı frm2=new KrediKartı();
                frm2.ShowDialog();
            }
        }

        private void btnSpTemizle_Click(object sender, EventArgs e)
        {
            listSepet.Items.Clear();//Sepet Temizler.
            txtToplamTutar.Text = Convert.ToString(0);
            sepetTutar = 0;
            
            

        }

        private void btnSepetCikar_Click(object sender, EventArgs e)
        {

           


        }
    }
}
