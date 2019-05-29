using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişOtomasyonProje
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }

        public virtual string KisiBilgiGoster()
        {
            string mesaj = "";

            mesaj += this.Ad + "" + this.Soyad + this.Adres + "  " + Environment.NewLine;
            return mesaj;
        }
        public Kisi()
        {

        }
    }
}
