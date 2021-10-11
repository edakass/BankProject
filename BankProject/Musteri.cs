using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BankProject
{
    /*
     parametre:fonksiyonun tanımında kullanılan ve 
     kullanıcıdan istenen veriyi tutacak olan değişkenlerdir.
     int ustAl(int taban,int ust) yani bizim burada parametrelerimiz taban ve ust 'dur.
     Bu parametrelere değer bırakması gerekiyor.
     ustAl(3,2) buradaki 3 ve 2 ye argüman deniliyor.Kullanıcının verdiği değerlere ise argüman deniliyor.

    Değişken bizim verdiğimiz bilgiyi saklarlar
     */
    abstract class Musteri : Kisi, IMusteriOzellikleri
    {
        public DateTime Tarih { get; set; }
        /*
         Get ve set kavramları temelde belli özelliklerin (property) yönünü belirtir.
         yani hem ayarlanabilir (set) hem de okunabilir (get) 
        Get Ne demek?
        Almak” anlamını taşımaktadır. Eğer bir değişkenin içeriği 
        yazılımımızın başka bir bölümünden erişilip okunabilecek ise bu durumda o özelliği (property) GET özellikli olarak tanımlamamız gerekmektedir.
        GET => Değişken okunmak istendiğinde eğer değişken GET özellikli tanımlandı ise okunacak sonucu,
        SET => Değişken içeriği değiştirilmek istendiğinde eğer değişken SET özellikli tanımlandı ise yazılabilmesini sağlıyor.
         */

        public string musteriTipi { get; set; }
       // public olarak bildirildiği için bu üyelere doğrudan erişilip değerler atanabilir.
        public List<Hesap> hesaplar;
        Hesap h; //Hesap h  nesnesi oluşturarak,hesap açma işlemini gerçekleştireceğiz.
        string rapor;
        DateTime tarih;//Bu raporun hangi tarihte yapıldığını tutmak için bu tarih değişkenini kullanıyoruz.
        //constructor yapıyoruz,ctor yaptıktan sonra tab deyince geliyor
        //Constructor, nesne yönelimli programlama kavramı içerisinde bulunan sınıf yapılarının nesne olarak tanımlanmasında
        //alt yapıyı hazırlayan, kurucu rolü üstlenen, sınıf ismi ile aynı isime sahip olan, geriye değer döndürmeyen fonksiyon türleridir.
        public Musteri()
        {
            hesaplar = new List<Hesap>();
            //Her müşteri sınıfından yeni bir nesne oluştuğunda bizim için hesaplar listesinden yeni bir liste oluşturuyor bizim için o müşteriye ait
        }
        public void HesapAc(int ekBakiye)
        {
            Random r = new Random();
            int sayi = r.Next(1000, 9999); //hesap numarası için rastgele 3 haneli sayı oluşturduk

            // h= hesap sınıfından yeni bir nesne oluşturmamız gerekiyor
            h = new Hesap();
            h.No = sayi;
            h.bakiye = 0; //başlangıç değeri olarak 0 olacak
            h.ekBakiye = ekBakiye; //personel tarafından belirlenen ek bakiye
            h.limit = ekBakiye; //biz hesabı kapatırken eşit olup olmadığına bakarız
            h.gunlukLimit = 1000;
            hesaplar.Add(h);
            System.Windows.Forms.MessageBox.Show("'" + ID + " Numaralı Müşteri için '" + sayi + " ' numaralı hesap '" + ekBakiye + "' ek bakiyesi ile açılmıitır.");
            //sayi random olarak tanımladığımız idi
        }

        public void HesapParaCek(Hesap h, decimal miktar)
        {
            if (h.ekBakiye != 0.0m && h.ekBakiye > 0.0m) //
            {
                if (h.gunlukLimit != 0.0m && h.gunlukLimit >= 0.0m)//kullanıcının günlük para çekme limitinin olup olmadığı ,0 dan yüksek bir rakam mı
                {//gunluk limitimizin 0 olmadığını teyit ediyoruz
                 //Günlük para çekme limiti dolmamışsa

                    if (h.gunlukLimit - miktar >= 0.0m)
                    // Çekilmek istenen para çekilince günlük para çekme limiti 0'a eşit olmuyorsa ve - değere düşmüyorsa
                    //burada günlük para çekme limitinin fazla olup olmadığını kontrol ediyoruz,fazla değilse çekme 
                    //işlemini gerçekleştiriyoruz.
                    //çekmek istediği miktar mesela günlük çekme miktarı 20 tl kalmış ama o da 30 çekmek istiyor gibi kontrol
                    {
                        if (h.bakiye >= miktar)
                        //Çekilmek istenen paranın tamamı bakiyede varsa
                        //bakiyeden çekilecek kısım
                        {
                            h.bakiye -= miktar;
                            h.gunlukLimit -= miktar; //Çekilen parayı günlük limitten düşüyoruz
                            System.Windows.Forms.MessageBox.Show("Bakiyenizden" + miktar + "' Lira çekildi.");
                            rapor = ("Bakiyenizden'" + miktar + "' Lira çekildi.");
                            tarih = DateTime.Today;
                            h.RaporEkle(rapor, tarih);

                        }
                        else if (h.bakiye > 0)
                        //Bakiye 0 dan büyükse (Örneğin bakiye 30tl müşteri 80 tl kalan 50tlyi ekbakiyeden çekeceği durumda burası çalışır.

                        //hem bakiyeden hem de ek bakiyeden çekileceği kısım
                        //çektiğimiz paranın geri kalan kısmı ek bakiyede geçerli mi
                        {
                            if (miktar - h.bakiye <= h.ekBakiye)
                                // Çekilmek istenen bir kısmı bakiyede var ve diğer kısmı ek bakiyeden çekilecekse ek bakiye limiti yeterliyse
                            {
                                decimal bakiyedenCekilen, ekBakiyedenCekilen;
                                bakiyedenCekilen = h.bakiye;
                                h.bakiye = 0;//Bakiye sıfırlanıyor
                                ekBakiyedenCekilen = miktar - bakiyedenCekilen;//ekBakiyeden çekilecek para hesaplanıyor

                                h.ekBakiye -= ekBakiyedenCekilen;//Çekilen para ekBakiyeden eksiltiliyor.

                                h.gunlukLimit -= bakiyedenCekilen + ekBakiyedenCekilen;//Çekilen parayı günlük limitten düşüyoruz



                                System.Windows.Forms.MessageBox.Show("'" + bakiyedenCekilen + "'Lira Bakiyeden, '" + ekBakiyedenCekilen + " ' Ek bakiyeden çekilmiştir");
                                rapor = ("'" + bakiyedenCekilen + "'Lira Bakiyeden, '" + ekBakiyedenCekilen + " ' Ek bakiyeden çekilmiştir");
                                tarih = DateTime.Today;
                                h.RaporEkle(rapor, tarih); //Hesap Özetine yapılan işlem ve tarihi gönderiliyor
                            }
                            else
                                System.Windows.Forms.MessageBox.Show("Ek bakiye limitiniz bu işlem için yeterli değildir.");
                        }
                        else
                        {
                            if (h.ekBakiye >= miktar)
                                //çekilmek istenen miktarın hepsinin ek bakiyeden çekileceği durum
                            {
                                h.ekBakiye -= miktar;
                                h.gunlukLimit -= miktar;

                                System.Windows.Forms.MessageBox.Show("'" + miktar + "' Lira Ek Bakiyeden çekilmiştir.");
                                rapor = ("'" + miktar + "'Lira Bakiyeden  çekilmiştir");
                                tarih = DateTime.Today;
                                h.RaporEkle(rapor, tarih);

                            }
                            else
                                System.Windows.Forms.MessageBox.Show("Bakiye ve Ek Bakiye bu işlem için yeterli değildir.");
                        }



                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Çekmek istediğiniz miktar kalan günlük para çekme limitinizden fazla olamaz");

                }
                else
                    System.Windows.Forms.MessageBox.Show("Günlük para çekme limitiniz dolmuştur.");


            }
            else
                System.Windows.Forms.MessageBox.Show("İşlem başarısız. \n Bakiye:0 \n  Ek Bakiye:0 ");
        
    }

        public void HesapParaYatir(Hesap h, decimal miktar)
        {

            decimal odenenBorc = 0;
            h.bakiye += miktar;
            System.Windows.Forms.MessageBox.Show("Hesabınıza '" + miktar + "' Lira eklenmiştir. \n Mevcut Bakiye: '" + h.bakiye + "' Lira ");
            rapor = ("Hesabınıza '" + miktar + "' Lira eklenmiştir. \n Mevcut Bakiye: '" + h.bakiye + "' Lira ");
            tarih = DateTime.Today;
            h.RaporEkle(rapor, tarih);

            //Eğer borcumuz varsa bakiyeden almamız gerekiyor.
            if (h.bakiye < h.limit)
                
            {
                decimal borc = h.limit - h.ekBakiye;

                for (decimal i = h.ekBakiye; h.ekBakiye < h.limit; i += 0.1m)
                { //200 400 ten küçük olduğu sürece
                   
                    if (h.bakiye == 0.0m) { break; }
                    else
                    {
                        h.bakiye -= 0.1m;
                        odenenBorc += 0.1m; //0.1 oranında arttırıyoruz
                        h.ekBakiye += 0.1m;
                    }
                }
                System.Windows.Forms.MessageBox.Show("'" + borc + "'Lira Ek Bakiye borcunuzun '" + odenenBorc + " Lira kadarı bakiyenizden tahsil edilmiştir.");
                rapor = ("'" + borc + "'Lira Ek Bakiye borcunuzun '" + odenenBorc + " Lira kadarı bakiyenizden tahsil edilmiştir.");
                tarih = DateTime.Today;
                h.RaporEkle(rapor, tarih);

            }
        }

        public void HesapSil(int hesapNo)
        {
            foreach (Hesap h in hesaplar.ToList())
            {
                if (hesapNo == h.No)
                {
                    if (h.bakiye == 0 && h.ekBakiye == h.limit) //Hesapta para yoksa ve ekBakiye borcu yoksa
                    {
                        hesaplar.Remove(h);
                        MessageBox.Show("'" + hesapNo + "' numaralı hesap başarıyla silindi.");
                    }
                    else
                        MessageBox.Show("'" + hesapNo + "' numaralı hesap silinebilmesi için bakiyesi 0 TL ve ek bakiye borcu olmamalıdır. \n Mevcut Bakiye: '" + h.bakiye + "' TL \n Güncel borç: '" + (h.limit - h.ekBakiye + "' TL"));
                }
            }

        }
    }
}
