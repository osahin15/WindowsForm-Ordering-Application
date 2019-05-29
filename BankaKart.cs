using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişOtomasyonProje
{
    public class BankaKart:Odeme
    {
        public Odeme OdemeMiktar { get; set; }
        public string Ad { get; set; }
        public ulong BankID { get; set; }
        public int Sifre { get; set; }

      
    }
}
