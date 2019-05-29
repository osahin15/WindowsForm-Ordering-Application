using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişOtomasyonProje
{
    public class Urun:UrunOzellik
    {
        public string UrunAdi { get; set; }
        public int Stok { get; set; }

        public Urun()
        {

        }
        public override string UrunBilgiGoster()
        {
            string mesaj = "";
            mesaj += "Urun Kodu:" + UrunKodu + "Urun Adı:" + UrunAdi + "Stok Durumu:" + Stok + "Fiyat:" + Fiyat + "TL";
            return mesaj;
        }
    }
}
