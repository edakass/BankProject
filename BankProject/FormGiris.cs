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
    partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        public FormGiris(Banka banka) //form girişin constructor gibi çalışan metodu bu normalde böyle idi  public FormGiris()

        {
            InitializeComponent();
            this.banka = banka;
            //buradaki banka nesnesi  ile bize parametre olarak gelen banka
        }
        Banka banka;

        private void FormGiris_Load(object sender, EventArgs e)
        {


        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            //YÖNETİCİ GİRİŞİ
            //yönetici de şifre doğrulama olmuyor direk giriş yapılabiliyor
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            FormYonetici formYonetici = new FormYonetici(banka);
            formYonetici.TopLevel = false;
            panel1.Controls.Add(formYonetici);
            formYonetici.Show();
            formYonetici.Dock = DockStyle.Fill;

        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            //PERSONEL GİRİŞİ
            //personel giriş de  kullanıcı adı parola doğruluma var
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            //foreach döngüsü kullanarak bu kullanıcı adına sahip personeli,personel listesinden 
            //aramamız gerekiyor 
            foreach(Personel p in banka.personeller)
            {
                if(kullaniciAdi==p.ID && sifre == p.Sifre)
                {
                    Form1 form1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = form1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();


                    FormPersonel formPersonel = new FormPersonel(banka);
                    formPersonel.TopLevel = false;
                    panel1.Controls.Add(formPersonel);
                    formPersonel.Show();
                    formPersonel.Dock = DockStyle.Fill;
                    MessageBox.Show("Hoş geldiniz. \n Sayın "+p.Ad+" "+p.Soyad);



                }
            }

        }

        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
            //MÜŞTERİ GİRİŞİ
            string musteriNo = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                if(musteriNo==m.ID && sifre == m.Sifre)
                {
                    
                    Form1 form1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = form1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();


                    FormMusteri formMusteri = new FormMusteri(banka,m);
                    //müşteri sınıfını açarken müşterininde nesnesini göndermemiz gerekiyor (banka,m) foreach deki m,
                    //bu gerkeiyor ki biz diğer form a geçince biz bu kullanıcı adını/müşterinumarasını gönderebiliriz ama 
                    //tekrar arama yapmamız gerekiyor  ,hangi müşteriye ait olduğunu kolay bulmamız için  ????
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz Sayın "+m.Ad+" "+m.Soyad);
                }

            }

            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                if (musteriNo == m.ID && sifre == m.Sifre)
                {
                    Form1 form1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = form1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();


                    FormMusteri formMusteri = new FormMusteri(banka, m);
                    //müşteri sınıfını açarken müşterininde nesnesini göndermemiz gerekiyor (banka,m) foreach deki m,
                    //bu gerkeiyor ki biz diğer form a geçince biz bu kullanıcı adını/müşterinumarasını gönderebiliriz ama 
                    //tekrar arama yapmamız gerekiyor  ,hangi müşteriye ait olduğunu kolay bulmamız için  ????
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz Sayın " + m.Ad + " " + m.Soyad);
                }

            }


        }
    }
}
