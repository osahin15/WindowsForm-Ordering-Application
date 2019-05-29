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
    public partial class BankaKarti : Form
    {
        public int hak = 3;
        public BankaKarti()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            
            BankaKart bKart=new BankaKart();

           
            
            bKart.BankID =123456789;
            bKart.Sifre = 1234;

            if (txtBankNo.Text==""||txtBankSifre.Text=="")

            {

                MessageBox.Show("Boşlukları doldurunuz..");

            }
            else if (txtBankNo.Text == bKart.BankID.ToString() && txtBankSifre.Text == bKart.Sifre.ToString())
            { 
                    this.Close();
                    
            }
            else
            {
                   
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Kontrol Ediniz.."+hak);
                hak--;
                txtBankNo.Clear();
                txtBankSifre.Clear();
                if (hak==0)
                {
                    Close();
                }
            }

        }
            
               
            





        
    }
}
