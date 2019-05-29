using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişOtomasyonProje
{
    public class Musteri:Kisi
    {
        public int MusteriNo { get; set; }
       

        public Musteri()
        {

        }

        public override string KisiBilgiGoster()
        {
            return base.KisiBilgiGoster();
        }
    }
}
