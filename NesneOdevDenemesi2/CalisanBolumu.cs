using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneOdevDenemesi2
{
    public partial class CalisanBolumu : Form
    {
        public CalisanBolumu()
        {
            InitializeComponent();
        }
        MusteriBolumu musteriForm = new MusteriBolumu();
        Dukkan d = new Dukkan();
        
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            d.satis = new Satis();

            if (cbKategoriEkle.Text == "Gida")
                u.urunkatalogu.KategoriAdi = "Gida";
            else if (cbKategoriEkle.Text == "Sarkuteri")
                u.urunkatalogu.KategoriAdi = "Sarkuteri";
            else if (cbKategoriEkle.Text == "Manav")
                u.urunkatalogu.KategoriAdi = "Manav";
            else if (cbKategoriEkle.Text == "Kasap")
                u.urunkatalogu.KategoriAdi = "Kasap";
            else if (cbKategoriEkle.Text == "Temizlik")
                u.urunkatalogu.KategoriAdi = "Temizlik";

            u.UrunAdi = txtAdi.Text;
            u.UrunKodu = Convert.ToInt32(txtKodu.Text);
            u.Tanim = txtTanim.Text;
            u.Fiyat = Convert.ToInt32(txtFiyat.Text);
            d.UrunEkle(u);

            MessageBox.Show("Urun Basarıyla Eklendi..");
            txtAdi.Text = "";
            txtFiyat.Text = "";
            txtKodu.Text = "";
            cbKategoriEkle.Text = "";
            txtTanim.Text = "";

            cbKategoriEkle.Focus();
        }

        private void btnStokListele_Click(object sender, EventArgs e)
        {
            txtStokListele.Text = d.UrunListele();
        }

        private void btnUrunCikar_Click(object sender, EventArgs e)
        {
            Urun u = d.urunBul(Convert.ToInt32(txtKoduCikar.Text));
            d.UrunCikar(u);
            MessageBox.Show("Seçtiğiniz ürün başarıyla silinmiştir...");
        }

        private void CalisanBolumu_Load(object sender, EventArgs e)
        {
            musteriForm.Show();
            
        }
    }
}
