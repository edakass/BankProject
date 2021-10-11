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
    partial class FormYonetici : Form
    {
        public FormYonetici(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
          //  this.dataGridPersonelListele.DataSource = banka.personeller;
        }

        Banka banka;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel; //bura
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel; //bura
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

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            //Personel Bilgilerini textBox'dan okuyup yeni nesneye ekliyoruz.
            string Ad = txtPersonelAdi.Text;
            string Soyad = txtPersonelSoyadi.Text;
            String ID = txtPersonelKullaniciAdi.Text;
            string Sifre = txtPersonelSifre.Text;

            //Personel eklendikten sonra textBoxları temizliyoruz.
            txtPersonelAdi.Clear();
            txtPersonelSoyadi.Clear();
            txtPersonelKullaniciAdi.Clear();
            txtPersonelSifre.Clear(); //textboxlarımızı temizlemiş olduk

            banka.PersonelEkle(Ad, Soyad, ID, Sifre); //Personel bilgilerini Banka sınıfındaki PersonelEkle metoduna gönderiyoruz.        

            this.dataGridPersonelListele.DataSource = null;
            this.dataGridPersonelListele.DataSource = banka.personeller;


            string rapor = ID+ " kullanıcı adına sahip personel bankadan eklendi ";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);
           // this.dataGridPersonelListele.DataSource = banka.personeller; //gridView öğesine personeller listesini yazdırıyoruz.


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String PersonelKullaniciAdi = txtPersonelSilKulAdi.Text;
            txtPersonelSilKulAdi.Clear();

            banka.PersonelSilme(PersonelKullaniciAdi);

            this.dataGridPersonelListele.DataSource = null;
            this.dataGridPersonelListele.DataSource = banka.personeller;

            string rapor = PersonelKullaniciAdi + " kullanıcı adına sahip personel bankadan silindi ";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);

        }

        private void btnBankaIslemListele_Click(object sender, EventArgs e)
        {
            dataGridBankaIslemListele.DataSource = null;
            dataGridBankaIslemListele.DataSource = banka.BankaRaporListesi;
            labelToplamPara.Text = "Banka Toplam Para : " + banka.toplamPara + " TL";


           // toplamPara

        }
        
        
         //private void Form2_Load(object sender, EventArgs e)
       // {
       //     this.gridPersonelListele.DataSource = banka.personeller;
       // }

        private void dataGridPersonelListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPersonelSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece harf girmesini istiyorsak
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

 

        private void txtPersonelAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece harf girmesini istiyorsak
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void txtPersonelSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }
    }
}
