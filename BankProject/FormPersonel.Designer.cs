
namespace BankProject
{
    partial class FormPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioTicariMusteri = new System.Windows.Forms.RadioButton();
            this.radioBireyselMusteri = new System.Windows.Forms.RadioButton();
            this.btnMusteriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeMusteri = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHesapAc = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMusteriHesapEkBakiye = new System.Windows.Forms.TextBox();
            this.txtMusteriHesapAcNo = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHesapSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersMusHesapNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1073, 671);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1073, 671);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Müşteri Ekle";
            this.tabNavigationPage1.Controls.Add(this.simpleButton5);
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Size = new System.Drawing.Size(1073, 626);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(3, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton5.Size = new System.Drawing.Size(41, 39);
            this.simpleButton5.TabIndex = 13;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioTicariMusteri);
            this.groupBox1.Controls.Add(this.radioBireyselMusteri);
            this.groupBox1.Controls.Add(this.btnMusteriKaydet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeMusteri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMusteriSifre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMusteriNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMusteriSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMusteriAd);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(76, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 565);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(291, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Müşteri Tipi:";
            // 
            // radioTicariMusteri
            // 
            this.radioTicariMusteri.AutoSize = true;
            this.radioTicariMusteri.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTicariMusteri.ForeColor = System.Drawing.Color.Purple;
            this.radioTicariMusteri.Location = new System.Drawing.Point(369, 350);
            this.radioTicariMusteri.Name = "radioTicariMusteri";
            this.radioTicariMusteri.Size = new System.Drawing.Size(136, 23);
            this.radioTicariMusteri.TabIndex = 12;
            this.radioTicariMusteri.TabStop = true;
            this.radioTicariMusteri.Text = "Ticari Müşteri";
            this.radioTicariMusteri.UseVisualStyleBackColor = true;
            // 
            // radioBireyselMusteri
            // 
            this.radioBireyselMusteri.AutoSize = true;
            this.radioBireyselMusteri.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBireyselMusteri.ForeColor = System.Drawing.Color.Purple;
            this.radioBireyselMusteri.Location = new System.Drawing.Point(180, 350);
            this.radioBireyselMusteri.Name = "radioBireyselMusteri";
            this.radioBireyselMusteri.Size = new System.Drawing.Size(156, 23);
            this.radioBireyselMusteri.TabIndex = 11;
            this.radioBireyselMusteri.TabStop = true;
            this.radioBireyselMusteri.Text = "Bireysel Müşteri";
            this.radioBireyselMusteri.UseVisualStyleBackColor = true;
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriKaydet.Appearance.Options.UseFont = true;
            this.btnMusteriKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriKaydet.ImageOptions.Image")));
            this.btnMusteriKaydet.Location = new System.Drawing.Point(239, 441);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(245, 50);
            this.btnMusteriKaydet.TabIndex = 10;
            this.btnMusteriKaydet.Text = "Müşteri Kaydet";
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(132, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // dateTimeMusteri
            // 
            this.dateTimeMusteri.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeMusteri.Location = new System.Drawing.Point(369, 127);
            this.dateTimeMusteri.Name = "dateTimeMusteri";
            this.dateTimeMusteri.Size = new System.Drawing.Size(200, 22);
            this.dateTimeMusteri.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(132, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Location = new System.Drawing.Point(369, 239);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.PasswordChar = '*';
            this.txtMusteriSifre.Size = new System.Drawing.Size(200, 30);
            this.txtMusteriSifre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(132, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(369, 181);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(200, 30);
            this.txtMusteriNo.TabIndex = 7;
            this.txtMusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(132, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri Numarası:";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(369, 80);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(200, 30);
            this.txtMusteriSoyad.TabIndex = 6;
            this.txtMusteriSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriSoyad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(132, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(369, 34);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(200, 30);
            this.txtMusteriAd.TabIndex = 5;
            this.txtMusteriAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriAd_KeyPress);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Hesap Aç";
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.simpleButton1);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Size = new System.Drawing.Size(1073, 626);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnHesapAc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMusteriHesapEkBakiye);
            this.groupBox2.Controls.Add(this.txtMusteriHesapAcNo);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(280, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 372);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(72, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Müşteri Numarası:";
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAc.Appearance.Options.UseFont = true;
            this.btnHesapAc.Location = new System.Drawing.Point(199, 250);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(164, 63);
            this.btnHesapAc.TabIndex = 18;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(72, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ek Bakiye Miktarı:";
            // 
            // txtMusteriHesapEkBakiye
            // 
            this.txtMusteriHesapEkBakiye.Location = new System.Drawing.Point(304, 175);
            this.txtMusteriHesapEkBakiye.Name = "txtMusteriHesapEkBakiye";
            this.txtMusteriHesapEkBakiye.Size = new System.Drawing.Size(227, 30);
            this.txtMusteriHesapEkBakiye.TabIndex = 17;
            this.txtMusteriHesapEkBakiye.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtMusteriHesapEkBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriHesapEkBakiye_KeyPress);
            // 
            // txtMusteriHesapAcNo
            // 
            this.txtMusteriHesapAcNo.Location = new System.Drawing.Point(304, 121);
            this.txtMusteriHesapAcNo.Name = "txtMusteriHesapAcNo";
            this.txtMusteriHesapAcNo.Size = new System.Drawing.Size(227, 30);
            this.txtMusteriHesapAcNo.TabIndex = 16;
            this.txtMusteriHesapAcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriHesapAcNo_KeyPress);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(41, 39);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Hesap Sil";
            this.tabNavigationPage3.Controls.Add(this.groupBox3);
            this.tabNavigationPage3.Controls.Add(this.simpleButton2);
            this.tabNavigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.ImageOptions.Image")));
            this.tabNavigationPage3.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage3.Size = new System.Drawing.Size(1073, 626);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnHesapSil);
            this.groupBox3.Controls.Add(this.txtPersMusHesapNo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(189, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 408);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hesap Silme İşlemleri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(52, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(546, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Hesabın silinebilmesi için bakiyesi ve ek bakiyesi 0 olmalı";
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapSil.Appearance.Options.UseFont = true;
            this.btnHesapSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapSil.ImageOptions.Image")));
            this.btnHesapSil.Location = new System.Drawing.Point(275, 266);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(231, 78);
            this.btnHesapSil.TabIndex = 16;
            this.btnHesapSil.Text = "Hesap Sil";
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // txtPersMusHesapNo
            // 
            this.txtPersMusHesapNo.Location = new System.Drawing.Point(306, 160);
            this.txtPersMusHesapNo.Name = "txtPersMusHesapNo";
            this.txtPersMusHesapNo.Size = new System.Drawing.Size(292, 30);
            this.txtPersMusHesapNo.TabIndex = 15;
            this.txtPersMusHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersMusHesapNo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(115, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Hesap Numarası:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(3, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(41, 39);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 671);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioTicariMusteri;
        private System.Windows.Forms.RadioButton radioBireyselMusteri;
        private DevExpress.XtraEditors.SimpleButton btnMusteriKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txtMusteriHesapEkBakiye;
        private System.Windows.Forms.TextBox txtMusteriHesapAcNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnHesapAc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersMusHesapNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnHesapSil;
        private System.Windows.Forms.Label label10;
    }
}