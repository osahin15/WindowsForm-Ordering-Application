using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişOtomasyonProje
{
    public class Kredi:Odeme
    {
        public Odeme OdemeMiktar { get; set; }
        public ulong KartNo { get; set; }
        public string Tip { get; set; }
        public string SonKullanimTarihi { get; set; }
        public int Sifre { get; set; }


        public Kredi()
        {

        }
    }
}
