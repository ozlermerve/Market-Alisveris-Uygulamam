using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevDenemesi2
{
    
    public  class Musteri
    {
        private List<Kisi> Kisiler = new List<Kisi>();
        
        public void KisiEkle(Kisi k)
        {
            Kisiler.Add(k);
        }
        
       
    }
}
