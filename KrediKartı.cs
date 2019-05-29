using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparişOtomasyonProje
{
    public partial class KrediKartı : Form
    {
        public int hak=3;
        public KrediKartı()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

            Kredi kkart = new Kredi();


            kkart.KartNo = 123456789;
            kkart.Sifre = 1234;
            kkart.Tip = "MasterCard";
            kkart.SonKullanimTarihi = "07.20";

            if (txtKrediNo.Text==""||txtKrediSifre.Text=="")
            {
                MessageBox.Show("Kart No ve Şİfre boş olamaz.!!");


            }
            else if (txtKrediNo.Text==kkart.KartNo.ToString()&&txtKrediSifre.Text==kkart.Sifre.ToString()&&comboTip.Text==kkart.Tip&&mskTime.Text==kkart.SonKullanimTarihi)
            {
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Kontrol Ediniz.. Kalan Denem Hakkınız:" + hak);
                hak--;
                txtKrediNo.Clear();
                txtKrediSifre.Clear();
                comboTip.ResetText();
                 mskTime.Clear();

                if (hak==0)
                {
                    Close();
                }
            }
            
             
            


        }
    }
}
