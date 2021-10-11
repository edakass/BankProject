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
    partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }
        public FormPersonel(Banka banka)
        {
            //her form geçişlerinde taşıdığımız banka nesnesini burdaki banka nesnesine atamamız gerekiyor ki aynı banka nesnesi üzerinden işlem yapabilelim

            InitializeComponent();
            this.banka = banka;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Banka banka;
        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtMusteriAd.Text;
            string soyad = txtMusteriSoyad.Text;
            string kullaniciAdi = txtMusteriNo.Text;
            string sifre = txtMusteriSifre.Text;
            DateTime tarih = dateTimeMusteri.Value;     

            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            txtMusteriNo.Clear();
            txtMusteriSifre.Clear();
           

            if (radioBireyselMusteri.Checked == true)
            {
                banka.MusteriEkle(true, ad, soyad, kullaniciAdi, sifre, tarih);
                string rapor = kullaniciAdi + " kullanıcı adına sahip " + ad + " " + soyad + " kişisi Ticari Müşteri olarak bankaya eklendi";
                banka.RaporEkle(rapor, tarih);
            }
            else if (radioTicariMusteri.Checked == true)
            {
                banka.MusteriEkle(false, ad, soyad, kullaniciAdi, sifre, tarih);
                string rapor = kullaniciAdi + " kullanıcı adına sahip " + ad + " " + soyad + " kişisi Ticari Müşteri olarak bankaya eklendi";
                banka.RaporEkle(rapor, tarih);
            }
            else //Müşteri tipi girilmemişse
                MessageBox.Show("Müşteri Tipi Seçmediniz. Lütfen Müşteri Tipini Seçiniz.");

        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            string musteriNo = txtMusteriHesapAcNo.Text;
            int ekBakiye = Convert.ToInt32(txtMusteriHesapEkBakiye.Text);

            txtMusteriHesapAcNo.Clear();
            txtMusteriHesapEkBakiye.Clear();


            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                if (musteriNo == m.ID)
                {
                    m.HesapAc(ekBakiye);

                    String rapor = m.ID + " kullanıcı adına sahip Bireysel Müşteri için yeni hesap açıldı.";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }

            }

            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                if (musteriNo == m.ID) //Müşteri bireysel müşteri mi kontrol ediyoruz

                {
                    m.HesapAc(ekBakiye);

                    String rapor = m.ID + " kullanıcı adına sahip Ticari Müşteri için yeni hesap açıldı.";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }

            }
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtPersMusHesapNo.Text);
            //veriyi aldık daha sonra int tipine dönüştürdük

            txtPersMusHesapNo.Clear();

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            //Müşteri bireysel müşteri mi kontrol ediyoruz

            {
                foreach ( Hesap h in m.hesaplar.ToList())
                //Her bir müşterinin hesaplar listesini tarayarak girilen hesap numarasına ait müşteriyi buluyoruz.

                {
                    if (hesapNo == h.No) //en sonlardan bunu değiştirdim 09.09.2021 -11.51
                    {
                        
                        m.HesapSil(hesapNo); //Müşterinin HesapSil metodunu çalıştırıyoruz.

                       string rapor = m.ID + " kullanıcı adına sahip Bireysel Müşterinin  " + hesapNo + " numaralı hesabı silindi.";
                       DateTime tarih = DateTime.Today;
                       banka.RaporEkle(rapor, tarih);

                    }   
                }     
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            //Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                foreach (Hesap h in m.hesaplar.ToList())
                {
                    if (hesapNo == h.No)
                    { 
                        m.HesapSil(hesapNo);

                        string rapor = m.ID + " kullanıcı adına sahip Ticari Müşterinin  " + hesapNo + " numaralı hesabı silindi.";
                        DateTime tarih = DateTime.Today;
                        banka.RaporEkle(rapor, tarih);

                    }
                   
                }
            }


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

        private void simpleButton1_Click(object sender, EventArgs e)
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

        //TextBoxlara sadece harf veya rakam girilmesine izin verilmesi
        private void txtMusteriAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtMusteriSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam alan bir yer olmalı
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMusteriHesapAcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMusteriHesapEkBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPersMusHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
