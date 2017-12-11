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
    public partial class MusteriBolumu : Form
    {
        public MusteriBolumu()
        {
            InitializeComponent();
        }
        
        int toplamTutar = 0;
        String sepetText = "";
        Dukkan d = new Dukkan();
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            sepetText += cbUrunler.SelectedItem+" "+txtUrunFiyati.Text+Environment.NewLine+Environment.NewLine;
            textBox3.Text = "";
            textBox3.Text = sepetText;
            toplamTutar += Convert.ToInt32(txtUrunFiyati.Text);

            Urun u = d.urunBul(Convert.ToInt32(txtUrunKodu.Text));
            d.UrunCikar(u);

            cbKategoriEkle.Text = "";
            cbUrunler.Text = "";
            txtUrunFiyati.Text = "";
            txtUrunTanimi.Text = "";
            txtUrunKodu.Text = "";
            cbKategoriEkle.Focus();
            textBox4.Text = toplamTutar.ToString();

           cbKategoriEkle.Text = "";
            txtUrunTanimi.Text = "";
        }
        private void MusteriBolumu_Load(object sender, EventArgs e)
        {
            Personel p1 = new Personel(1);
            p1.Ad = "Merve";
            p1.Soyad = "Ozler";
            p1.TcKimlikNo = 12345;

            Personel p2 = new Personel(2);
            p2.Ad = "Kubra";
            p2.Soyad = "Tas";
            p2.TcKimlikNo = 98765;

            Personel p3 = new Personel(3);
            p3.Ad = "Ozge";
            p3.Soyad = "Arı";
            p3.TcKimlikNo = 85214;

            cmbKasiyer.Items.Add(p1.Ad + " " + p1.Soyad);
            cmbKasiyer.Items.Add(p2.Ad + " " + p2.Soyad);
            cmbKasiyer.Items.Add(p3.Ad + " " + p3.Soyad);

            DateTime now = DateTime.Now;
            textBox7.Text = now.ToString();
        }
        
        private void cbKategoriEkle_SelectedValueChanged(object sender, EventArgs e)
        {   
            cbUrunler.Items.Clear();
            for (int i = 0; i < Dukkan.Urunler.Count; i++)
            {
                if (Dukkan.Urunler[i].urunkatalogu.KategoriAdi == cbKategoriEkle.SelectedItem.ToString())
                {
                    cbUrunler.Items.Add(Dukkan.Urunler[i].UrunAdi);
                }
            }
        }
               
        private void button1_Click(object sender, EventArgs e)
        {  }
        private void tabPage2_Click(object sender, EventArgs e)
        {  }


        Musteri m = new Musteri();
        private void button3_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.Ad = txtMusteriAd.Text;
            k.Soyad = txtMusteriSoyad.Text;
            tabControl1.SelectedTab = tabPage4;
            textBox5.Text = k.Ad;
            textBox6.Text = k.Soyad;         
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {}

        private void cbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbUrunler.SelectedIndex;
            String urunAdi = (String)cbUrunler.SelectedItem;
            for (i = 0; i < Dukkan.Urunler.Count; i++)
            {
                if (urunAdi == Dukkan.Urunler[i].UrunAdi)
                {
                    txtUrunKodu.Text = Dukkan.Urunler[i].UrunKodu.ToString();
                    txtUrunTanimi.Text = Dukkan.Urunler[i].Tanim.ToString();
                    txtUrunFiyati.Text = Dukkan.Urunler[i].Fiyat.ToString();
                    break;
                }
            }
        }
        
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alışveriş işleminiz başarıyla tamamlanmıştır...");
            cmbKasiyer.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text="";
        }
        
        private void btnAlisverisiTamamla_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        
    }
}
