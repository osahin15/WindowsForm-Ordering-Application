using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişOtomasyonProje
{
    public class Siparis:SiparisDetay
    {
        public DateTime SiparisTarihi { get; set; }
        public UrunOzellik urun { get; set; }
        public string SiparisDurum { get; set; }

        public Siparis()
        {

        }

        
    }
}
