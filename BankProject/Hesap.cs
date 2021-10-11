using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankProject
{
    class Hesap :IRaporOzellikleri
    {
        public int No { get; set; }
        public decimal bakiye { get; set; }
        public decimal gunlukLimit { get; set; }
        public decimal limit { get; set; }
        public decimal ekBakiye { get; set; }
        public List<Rapor> RaporListesi;
        /*Rapor listesi için bu sınıfa ait işlemler burada tutulacak.
         * Biz her yeni işlemde rapor sınıfından yeni bir nesne oluşturacağız,rapor ve tarih değişkenlerini
         * doldurduktan sonra burdaki hesap sınıfının o hesaba ait rapor listesini buna ekliyeceğiz.
         * Daha sonra DataGridview ile ekrana basıyor olucağız.
         */
        Rapor r;
        public Hesap()
        {
            //ctor ile rapor listesi oluşturalim her yeni hesap açıldığında.
            RaporListesi = new List<Rapor>();
        }
        public void RaporEkle(string rapor, DateTime tarih)
        {
            r = new Rapor();
            this.r.rapor = rapor;
            this.r.tarih = tarih;
            RaporListesi.Add(r);
        }
    }
}
