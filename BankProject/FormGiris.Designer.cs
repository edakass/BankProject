
namespace BankProject
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnYoneticiGiris = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(37, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(436, 113);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(122, 30);
            this.txtSifre.TabIndex = 3;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(436, 52);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(122, 30);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(96, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(93, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı/Müşteri Numarası:";
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGiris.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMusteriGiris.Appearance.Options.UseFont = true;
            this.btnMusteriGiris.Appearance.Options.UseForeColor = true;
            this.btnMusteriGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriGiris.ImageOptions.Image")));
            this.btnMusteriGiris.Location = new System.Drawing.Point(6, 50);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMusteriGiris.Size = new System.Drawing.Size(191, 93);
            this.btnMusteriGiris.TabIndex = 4;
            this.btnMusteriGiris.Text = "Müşteri Girişi";
            this.btnMusteriGiris.Click += new System.EventHandler(this.btnMusteriGiris_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGiris.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPersonelGiris.Appearance.Options.UseFont = true;
            this.btnPersonelGiris.Appearance.Options.UseForeColor = true;
            this.btnPersonelGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelGiris.ImageOptions.Image")));
            this.btnPersonelGiris.Location = new System.Drawing.Point(230, 50);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPersonelGiris.Size = new System.Drawing.Size(205, 93);
            this.btnPersonelGiris.TabIndex = 5;
            this.btnPersonelGiris.Text = "Personel Girişi";
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiGiris.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYoneticiGiris.Appearance.Options.UseFont = true;
            this.btnYoneticiGiris.Appearance.Options.UseForeColor = true;
            this.btnYoneticiGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYoneticiGiris.ImageOptions.Image")));
            this.btnYoneticiGiris.Location = new System.Drawing.Point(496, 50);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnYoneticiGiris.Size = new System.Drawing.Size(219, 93);
            this.btnYoneticiGiris.TabIndex = 6;
            this.btnYoneticiGiris.Text = "Yönetici Girişi";
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYoneticiGiris);
            this.groupBox2.Controls.Add(this.btnPersonelGiris);
            this.groupBox2.Controls.Add(this.btnMusteriGiris);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(31, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnMusteriGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGiris;
        private DevExpress.XtraEditors.SimpleButton btnYoneticiGiris;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}