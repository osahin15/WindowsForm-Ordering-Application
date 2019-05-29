using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişOtomasyonProje
{
    public abstract class UrunOzellik
    {
        public int UrunKodu { get; set; }
        public decimal Fiyat { get; set; }
        public int SepetUrunAdet { get; set; }

        public UrunOzellik()
        {
            SepetUrunAdet = 0;
        }
        public abstract string UrunBilgiGoster();


    }
}
