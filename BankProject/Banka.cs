using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BankProject
{
    class Banka : IBankaOzellikleri, IRaporOzellikleri
    {
        public List<Personel> personeller = new List<Personel>();
        public List<BireyselMusteri> BireyselMusteriler = new List<BireyselMusteri>();
        public List<TicariMusteri> TicariMusteriler = new List<TicariMusteri>();
        public List<Rapor> BankaRaporListesi = new List<Rapor>();
        public decimal toplamPara { get; set; }

        Personel p;
        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        Rapor r;
        String rapor;
        DateTime tarih;


        public void MusteriEkle(bool musteriTipi, string ad, string soyad, string ID, string sifre, DateTime tarih)
        {
            if (musteriTipi == true)
            {
                bireyselMusteri = new BireyselMusteri();//nesne oluşturduk burada,bireysel müşteriden yeni bir nesne oluşturduk          
                this.bireyselMusteri.Ad = ad;
                this.bireyselMusteri.Soyad = soyad;
                this.bireyselMusteri.ID = ID;
                this.bireyselMusteri.Sifre = sifre;
                this.bireyselMusteri.Tarih = tarih;
                this.bireyselMusteri.musteriTipi = "Bireysel";
                BireyselMusteriler.Add(bireyselMusteri);
                System.Windows.Forms.MessageBox.Show(" Bireysel Müşteri Başarıyla Eklendi");

                rapor = ("'" + ID + "' ID Numaralı Bireysel Müşteri Başarıyla Eklendi.");
                tarih = DateTime.Today;
                RaporEkle(rapor, tarih);

            }
            else
            {
                ticariMusteri = new TicariMusteri();
                this.ticariMusteri.Ad = ad;
                this.ticariMusteri.Soyad = soyad;
                this.ticariMusteri.ID = ID;
                this.ticariMusteri.Sifre = sifre;
                this.ticariMusteri.Tarih = tarih;
                this.ticariMusteri.musteriTipi = "Ticari ";

                TicariMusteriler.Add(ticariMusteri);
                System.Windows.Forms.MessageBox.Show(" Ticari Müşteri Başarıyla Eklendi");

                rapor = ("'" + ID + "' ID Numaralı Ticari Müşteri Başarıyla Eklendi.");
                tarih = DateTime.Today;
                RaporEkle(rapor, tarih);
            }
        }
        public void PersonelEkle(string ad, string soyad, string ID, string sifre)
        {
            p = new Personel();
            p.Ad = ad;
            p.Soyad = soyad;
            p.ID = ID;
            p.Sifre = sifre;

            personeller.Add(p);
            System.Windows.Forms.MessageBox.Show("'" + ID + " ' Personel Başarıyla Eklendi");

            rapor = ("'" + ID + " Personel Başarıyla Eklendi");
            tarih = DateTime.Today;
            RaporEkle(rapor, tarih);
        }

        public void PersonelSilme(string kullaniciAdi)
        {
            foreach (Personel p in personeller.ToList())  {
                //eğer to list kullanmazsak personel silme işleminden sonra hata verebiliyor.
                if (p.ID == kullaniciAdi) //p.id eşitse parametre olarak gelen kullanıcı adına 
                {
                    personeller.Remove(p);               
                }

            }
            System.Windows.Forms.MessageBox.Show("'" + kullaniciAdi + " Personel Başarıyla Silindi");

            rapor = ("'" + kullaniciAdi + " Personel Başarıyla Silindi");
            tarih = DateTime.Today;
            RaporEkle(rapor, tarih);
        }
        public void RaporEkle(string rapor, DateTime tarih)
        {
            r = new Rapor();
            this.r.rapor = rapor;
            this.r.tarih = tarih;
            BankaRaporListesi.Add(r);
        }
    }
}
