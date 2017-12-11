using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevDenemesi2
{
    public class Satis
    {
        protected DateTime Tarih { get; set; }
        public int Tutar { get; set; }
        public Musteri musteri { get; set; }
        public Satis()
        {
            this.musteri = new Musteri();
        }
   
    }
}
