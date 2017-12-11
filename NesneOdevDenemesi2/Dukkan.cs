using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevDenemesi2
{
    public class Dukkan
    {
        public static List<Urun> Urunler = new List<Urun>();
        public void UrunEkle(Urun u)
        {
            Urunler.Add(u);
        }
        public void UrunCikar(Urun u)
        {
            Urunler.Remove(u);
        }
        public string UrunListele()
        {
            string temp = "";
            foreach (Urun item in Urunler)
            {
                temp += "UrunKategorisi: " + item.urunkatalogu.KategoriAdi + Environment.NewLine +
                        "UrunKodu: " + item.UrunKodu + Environment.NewLine +
                        "UrunAdi: " + item.UrunAdi + Environment.NewLine +
                        "UrunTanimi: " + item.Tanim + Environment.NewLine +
                        "UrunFiyati: " + item.Fiyat + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
            return temp;
        }
        public Satis satis { get; set; }

        public Urun urunBul(int urunKodu)
        {
            foreach (Urun item in Urunler)
            {
                if (urunKodu == item.UrunKodu)
                    return item;
            }

            return new Urun();
        }
    
    }
}
