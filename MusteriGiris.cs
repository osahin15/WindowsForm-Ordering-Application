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
    public partial class MusteriGirisi : Form
    {
        MusteriForm musteri=new MusteriForm();

        public MusteriGirisi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriGrs_Click(object sender, EventArgs e)
        {
            if(txtMusteriGrs.Text=="musteri1"&&txtMusteriSifre.Text=="123456")
            {
                MusteriForm form1 = new MusteriForm();
                this.Hide();
                form1.Show();
            }
            else
            {
                label3.Show();
                txtMusteriGrs.Clear();
                txtMusteriSifre.Clear();
            }


           
        }

        private void MusteriGirisi_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }
    }
}
