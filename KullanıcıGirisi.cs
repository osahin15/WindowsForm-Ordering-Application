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
    public partial class KullanıcıGirisi : Form
    {
        public KullanıcıGirisi()
        {
            InitializeComponent();
        }

        private void btnKullaniciGrs_Click(object sender, EventArgs e)
        {
            if (txtKullaniciGrs.Text == "kullanici1" && txtKullaniciSifre.Text == "12345")
            {
                KullaniciForm form2 = new KullaniciForm();
                this.Hide();
                form2.Show();
            }
            else
            {
                label3.Show();
            }
        }

        private void KullanıcıGirisi_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }
    }
}