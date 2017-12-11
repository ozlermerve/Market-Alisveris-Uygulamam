using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevDenemesi2
{
    public class Urun:UrunTanimi
    {
        public string UrunAdi { get; set; }
        public UrunKatalogu urunkatalogu { get; set; }
        public Urun()
        {
            this.urunkatalogu = new UrunKatalogu();
        }

    }
}
