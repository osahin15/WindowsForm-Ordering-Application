using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SiparişOtomasyonProje
{
    public class Market:Urun
    {

        public List<Urun> Urunler { get; set; }
        public List<Musteri> Musteriler { get; set; }



        public Market()
        {
            this.Urunler = new List<Urun>();
            this.Musteriler = new List<Musteri>();
        }
    }
    
	
   
    
     

	
}
