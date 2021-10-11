using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }
        Banka banka;  //**
        BireyselMusteri bireyselM;
        TicariMusteri ticariM;
        bool musteri;
        // 2 tane constructor var birisi bireysel müşteri için diğeri ise ticari müşteriler için
        public FormMusteri(Banka banka,BireyselMusteri bireyselM)
        {

            //Bu form açıldığında giriş yapan müşteri bireysel ise bu constructor çalışır.
            InitializeComponent();
            this.banka = banka;
             //**banka ile =parametre olarak gelen banka
            this.bireyselM = bireyselM;
            musteri = true;

    }
        public FormMusteri(Banka banka,TicariMusteri ticariM)
        {
            //Bu form açıldığında giriş yapan müşteri ticari ise bu constructor çalışır.

            InitializeComponent();
            this.banka = banka;
            this.ticariM = ticariM;
            musteri = false;
        }
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtHesapNo.Text); 
            decimal miktar = Convert.ToDecimal(txtCekMiktar.Text);


            txtHesapNo.Clear();
            txtCekMiktar.Clear();


            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                        m.HesapParaCek(h, miktar);
                        
                }

            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                foreach (Hesap h  in m.hesaplar )
                {
                    if (hesapNo == h.No)
                        m.HesapParaCek(h, miktar);
                       
                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtYatirHesapNo.Text);
            decimal miktar = Convert.ToDecimal(txtYatirMiktar.Text);

            txtYatirHesapNo.Clear();
            txtYatirMiktar.Clear();

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                        m.HesapParaYatir(h, miktar);
                   

                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                        m.HesapParaYatir(h, miktar);
                       
                }
            }
        }

        private void btnHavaleGonder_Click(object sender, EventArgs e)
        {
            int kaynakNo = Convert.ToInt32(txtKaynakNo.Text);
            int hedefNo = Convert.ToInt32(txtHavaleNo.Text);
            int miktar = Convert.ToInt32(txtHavaleMiktar.Text);
            decimal bankaPayi = 0.0m, hedefPayi = 0.0m;
            decimal islemOrani = 0.0m;

            txtKaynakNo.Clear();
            txtHavaleNo.Clear();
            txtHavaleMiktar.Clear();
           
            Hesap kaynakHesap = null, hedefHesap = null;
            Musteri kaynakMusteri = null;
            bool kaynakDurum = false, hedefDurum = false, kaynakHesapTuru = false; //kaynakhesapturu=bireysel se true


            string rapor;
            DateTime tarih;

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {  //kaynak hesap bireysel müşteri iste
                foreach (Hesap h in m.hesaplar)
                {
                    if (kaynakNo == h.No)
                    {
                        kaynakHesap = h;//Kaynak hesabı buluyoruz
                        kaynakMusteri = m;//Kaynak müşteriyi buluyoruz
                        kaynakDurum = true;
                        kaynakHesapTuru = true;
                    }
                    if (kaynakNo == h.No)
                    {
                        hedefHesap = h;//hedef hesabı buluyoruz
                        kaynakMusteri = m;  //Kaynak müşteriyi buluyoruz
                        hedefDurum = true;
                        kaynakHesapTuru = true;
                    }
                }

            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {  //kaynak hesap ticari müşteri ise
                foreach (Hesap h in m.hesaplar)
                {
                    if (kaynakNo == h.No)
                    {
                        kaynakHesap = h;
                        kaynakMusteri = m;
                        kaynakDurum = true;
                
                    }
                    if (kaynakNo == h.No)
                    {
                        hedefHesap = h;
                       kaynakMusteri = m; //bura?
                        hedefDurum = true;
                      
                    }
                }

            }
            if(kaynakDurum==true && hedefDurum == true) //Kaynak ve Hedef hesap numaraları bulunduysa
            {
                
                    if (kaynakHesap.bakiye >= miktar) { 
                       // 
                      if (kaynakHesapTuru == true) //ticari müşteri
                       {       
                         islemOrani = 2.0m;
                        kaynakHesap.bakiye -= miktar;
                        bankaPayi = (miktar * islemOrani) / 100;
                        hedefPayi = miktar - bankaPayi;
                        banka.toplamPara += bankaPayi;
                        hedefHesap.bakiye += miktar;
                        MessageBox.Show("Hedef hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL");

                          tarih = DateTime.Today;
                       
                          rapor = kaynakNo + " numaralı hesabınızdan " + hedefNo + " numaralı hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL";

                        

                        rapor = (kaynakHesap.No + " numaralı hesabınızdan, " + hedefHesap.No + " numaralı hesaba " + miktar + " Lira gönderilmiştir.");
                         kaynakHesap.RaporEkle(rapor, tarih);

                        rapor = (kaynakHesap.No + " numaralı hesaptan, " + hedefHesap.No + " numaralı hesabınıza " + miktar + " Lira gönderilmiştir");
                        

                    }
                    else
                        MessageBox.Show("Bakiye yetersiz.");
                }
                else if (kaynakHesap.bakiye >= (miktar + miktar * 2 / 100)) {
                    //bireysel müşteri
                    kaynakHesap.bakiye -= miktar;
                    hedefHesap.bakiye += miktar;
                    bankaPayi = miktar * 2 / 100;
                    banka.toplamPara += bankaPayi;


                  tarih = DateTime.Today;
                    rapor = (kaynakNo + " numaralı hesabınızdan, " + hedefNo + " numaralı hesaba " + miktar + " Lira gönderilmiştir.");



                    rapor = (kaynakNo + " numaralı hesabınızdan, " + hedefNo + " numaralı hesaba " + miktar + " Lira gönderilmiştir.");
                    kaynakHesap.RaporEkle(rapor, tarih);

                   
                }
                else
                    MessageBox.Show("Kaynak,hedef hesap bulunamadı veya bakiye yetersiz.");
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //musteri true demek bireyselmüşteri
               if (musteri == true)
                   dataGridHesaplarim.DataSource = bireyselM.hesaplar;
               else
                   dataGridHesaplarim.DataSource = ticariM.hesaplar;

         
         

        }

        private void btnOzetListele_Click(object sender, EventArgs e)
        {

            int hesapNo = 0; //başlangıç değeri

            if (txtOzetHesappNo.Text != "") //hesap numarası boş değil ise
                                            //Hesap Özeti Listeleme TextViewi boş bırakılırsa hata vermemesi için

            {

                hesapNo = Convert.ToInt32(txtOzetHesappNo.Text);

                DateTime timeBaslangic = dateTimeBaslangic.Value;
                DateTime timeBitis = dateTimeBitis.Value;

                int BaslangicGun = timeBaslangic.Day;
                int bitisGun = timeBitis.Day;

                List<Rapor> GosterilecekRaporlar = new List<Rapor>();

                foreach (BireyselMusteri m in banka.BireyselMusteriler)
                {
                    foreach (Hesap h in m.hesaplar)
                    {
                        //rapor ile kontrol ediyoruz,belirlenen tarih aralığında mı değil mi diye
                        if (hesapNo == h.No)
                        {
                            foreach (Rapor r in h.RaporListesi)
                            {
                                //timespan 2 tarih arasındaki farkı alıyor
                                TimeSpan t = timeBitis - r.tarih; //her bir işlemin bitiş tarihini çıkarcaz  ->29-26
                                                                  //Seçilen bitiş tarihi ile işlem tarihi arasındaki farkı alıyoruz.

                                int baslangicDegeri = t.Days;   //Farkı güne çeviriyoruz.                                              //3
                                TimeSpan t2 = r.tarih - timeBaslangic;//18-10   14-19
                                int bitisDegeri = t2.Days;           //8    yada  -5    bu eksiili bir zaman aralığı vereceği için if bloğunun içine giremeyecek
                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)
                                //Eğer ki farklar - değer değilse yani belirtilen aralık arasındaysa 

                                {
                                    GosterilecekRaporlar.Add(r);
                                }
                            }
                        }
                    }

                }


                foreach (TicariMusteri m in banka.TicariMusteriler)
                {
                    foreach (Hesap h in m.hesaplar)
                    {
                        //rapor ile kontrol ediyoruz,belirlenen tarih aralığında mı değil mi diye
                        if (hesapNo == h.No)
                        {
                            foreach (Rapor r in h.RaporListesi)
                            {
                                //timespan 2 tarih arasındaki farkı alıyor
                                TimeSpan t = timeBitis - r.tarih; //her bir işlemin bitiş tarihini çıkarcaz  ->29-26
                                int baslangicDegeri = t.Days;                                                 //3
                                TimeSpan t2 = r.tarih - timeBaslangic;//28-20   14-19
                                int bitisDegeri = t2.Days;           //8    yada  -5    bu eksiili bir zaman aralığı vereceği için if bloğunun içine giremeyecek
                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)
                                {
                                    GosterilecekRaporlar.Add(r);
                                }
                            }
                        }
                    }

                }
                //   dataGridHesapOzeti.DataSource = GosterilecekRaporlar;
                dataGridHesapOzeti.DataSource = GosterilecekRaporlar;

            }
            else
                MessageBox.Show("Lütfen hesap numarası giriniz");



           
        }

        private void dataGridHesapOzeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCekMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYatirHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYatirMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHavaleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKaynakNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHavaleMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOzetHesappNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }
    }
}
