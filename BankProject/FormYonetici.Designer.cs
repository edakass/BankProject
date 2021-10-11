
namespace BankProject
{
    partial class FormYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYonetici));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersonelSilKulAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridPersonelListele = new System.Windows.Forms.DataGridView();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBankaIslemListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelToplamPara = new System.Windows.Forms.Label();
            this.dataGridBankaIslemListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonelListele)).BeginInit();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBankaIslemListele)).BeginInit();
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
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(1245, 705);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1556, 881);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.Click += new System.EventHandler(this.tabPane1_Click);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Personel Ekle";
            this.tabNavigationPage1.Controls.Add(this.simpleButton2);
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1556, 836);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(4, 4);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(109, 81);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonelSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPersonelKullaniciAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPersonelSoyadi);
            this.groupBox1.Controls.Add(this.txtPersonelAdi);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(135, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(800, 524);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(254, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = " Lütfen sadece harf kullanın.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(210, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Appearance.Options.UseFont = true;
            this.btnPersonelEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelEkle.ImageOptions.Image")));
            this.btnPersonelEkle.Location = new System.Drawing.Point(326, 416);
            this.btnPersonelEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(250, 66);
            this.btnPersonelEkle.TabIndex = 9;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(210, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(451, 326);
            this.txtPersonelSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.PasswordChar = '*';
            this.txtPersonelSifre.Size = new System.Drawing.Size(124, 30);
            this.txtPersonelSifre.TabIndex = 8;
            this.txtPersonelSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSifre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(210, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // txtPersonelKullaniciAdi
            // 
            this.txtPersonelKullaniciAdi.Location = new System.Drawing.Point(451, 225);
            this.txtPersonelKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonelKullaniciAdi.Name = "txtPersonelKullaniciAdi";
            this.txtPersonelKullaniciAdi.Size = new System.Drawing.Size(124, 30);
            this.txtPersonelKullaniciAdi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(210, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(451, 156);
            this.txtPersonelSoyadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(124, 30);
            this.txtPersonelSoyadi.TabIndex = 6;
            this.txtPersonelSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyadi_KeyPress);
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(451, 99);
            this.txtPersonelAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(124, 30);
            this.txtPersonelAdi.TabIndex = 5;
            this.txtPersonelAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelAdi_KeyPress);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Personel Çıkar";
            this.tabNavigationPage2.Controls.Add(this.simpleButton3);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1556, 836);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(4, 4);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(51, 49);
            this.simpleButton3.TabIndex = 12;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.txtPersonelSilKulAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(524, 152);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(732, 436);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bilgileri";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(244, 270);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(301, 94);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Personel Çıkar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtPersonelSilKulAdi
            // 
            this.txtPersonelSilKulAdi.Location = new System.Drawing.Point(374, 166);
            this.txtPersonelSilKulAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonelSilKulAdi.Name = "txtPersonelSilKulAdi";
            this.txtPersonelSilKulAdi.Size = new System.Drawing.Size(239, 30);
            this.txtPersonelSilKulAdi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(89, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Personel Listele";
            this.tabNavigationPage3.Controls.Add(this.simpleButton4);
            this.tabNavigationPage3.Controls.Add(this.dataGridPersonelListele);
            this.tabNavigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.ImageOptions.Image")));
            this.tabNavigationPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1556, 836);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(4, 4);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(51, 49);
            this.simpleButton4.TabIndex = 12;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // dataGridPersonelListele
            // 
            this.dataGridPersonelListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonelListele.Location = new System.Drawing.Point(0, 88);
            this.dataGridPersonelListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridPersonelListele.Name = "dataGridPersonelListele";
            this.dataGridPersonelListele.RowHeadersWidth = 51;
            this.dataGridPersonelListele.RowTemplate.Height = 24;
            this.dataGridPersonelListele.Size = new System.Drawing.Size(1552, 733);
            this.dataGridPersonelListele.TabIndex = 0;
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Banka İşlem Listesi";
            this.tabNavigationPage4.Controls.Add(this.simpleButton5);
            this.tabNavigationPage4.Controls.Add(this.btnBankaIslemListele);
            this.tabNavigationPage4.Controls.Add(this.labelToplamPara);
            this.tabNavigationPage4.Controls.Add(this.dataGridBankaIslemListele);
            this.tabNavigationPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage4.ImageOptions.Image")));
            this.tabNavigationPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(1556, 836);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(4, 4);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton5.Size = new System.Drawing.Size(51, 49);
            this.simpleButton5.TabIndex = 12;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btnBankaIslemListele
            // 
            this.btnBankaIslemListele.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaIslemListele.Appearance.Options.UseFont = true;
            this.btnBankaIslemListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBankaIslemListele.ImageOptions.Image")));
            this.btnBankaIslemListele.Location = new System.Drawing.Point(149, 16);
            this.btnBankaIslemListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBankaIslemListele.Name = "btnBankaIslemListele";
            this.btnBankaIslemListele.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnBankaIslemListele.Size = new System.Drawing.Size(235, 60);
            this.btnBankaIslemListele.TabIndex = 2;
            this.btnBankaIslemListele.Text = "Listele";
            this.btnBankaIslemListele.Click += new System.EventHandler(this.btnBankaIslemListele_Click);
            // 
            // labelToplamPara
            // 
            this.labelToplamPara.AutoSize = true;
            this.labelToplamPara.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamPara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelToplamPara.Location = new System.Drawing.Point(424, 36);
            this.labelToplamPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamPara.Name = "labelToplamPara";
            this.labelToplamPara.Size = new System.Drawing.Size(195, 18);
            this.labelToplamPara.TabIndex = 1;
            this.labelToplamPara.Text = " Banka Toplam Para - Lira :";
            // 
            // dataGridBankaIslemListele
            // 
            this.dataGridBankaIslemListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBankaIslemListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBankaIslemListele.Location = new System.Drawing.Point(0, 90);
            this.dataGridBankaIslemListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridBankaIslemListele.Name = "dataGridBankaIslemListele";
            this.dataGridBankaIslemListele.RowHeadersWidth = 51;
            this.dataGridBankaIslemListele.RowTemplate.Height = 24;
            this.dataGridBankaIslemListele.Size = new System.Drawing.Size(1556, 746);
            this.dataGridBankaIslemListele.TabIndex = 0;
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 705);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormYonetici";
            this.Text = "FormYonetici";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonelListele)).EndInit();
            this.tabNavigationPage4.ResumeLayout(false);
            this.tabNavigationPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBankaIslemListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtPersonelSilKulAdi;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.DataGridView dataGridPersonelListele;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnBankaIslemListele;
        private System.Windows.Forms.Label labelToplamPara;
        private System.Windows.Forms.DataGridView dataGridBankaIslemListele;
        private System.Windows.Forms.Label label6;
    }
}