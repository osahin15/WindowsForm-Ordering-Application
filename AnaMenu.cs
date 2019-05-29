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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void kullanıcıGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıGirisi form1 = new KullanıcıGirisi();
            form1.MdiParent = this;
            form1.Show();
        }

        private void müşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGirisi form2 = new MusteriGirisi();
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
