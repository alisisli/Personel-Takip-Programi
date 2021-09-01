
namespace Personel_Programı
{
    partial class KullanıcıForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıForm));
            this.cmbKayitRol = new System.Windows.Forms.ComboBox();
            this.txtKayıtKAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKayıtSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKayıtSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKayıtAd = new System.Windows.Forms.TextBox();
            this.btnKayıtOnayla = new System.Windows.Forms.Button();
            this.chbKullanıcıEkle = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.chbKullanıcıSilme = new System.Windows.Forms.CheckBox();
            this.kulSilAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kulSilSifre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAyarlarSifre = new System.Windows.Forms.Button();
            this.chbAyarlarSifre = new System.Windows.Forms.CheckBox();
            this.txtAyarlarSifre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKayitRol
            // 
            this.cmbKayitRol.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cmbKayitRol.FormattingEnabled = true;
            this.cmbKayitRol.Items.AddRange(new object[] {
            "Yönetici",
            "Personel"});
            this.cmbKayitRol.Location = new System.Drawing.Point(187, 100);
            this.cmbKayitRol.Name = "cmbKayitRol";
            this.cmbKayitRol.Size = new System.Drawing.Size(296, 31);
            this.cmbKayitRol.TabIndex = 58;
            // 
            // txtKayıtKAdi
            // 
            this.txtKayıtKAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtKAdi.Location = new System.Drawing.Point(187, 260);
            this.txtKayıtKAdi.Name = "txtKayıtKAdi";
            this.txtKayıtKAdi.Size = new System.Drawing.Size(296, 30);
            this.txtKayıtKAdi.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 59;
            this.label3.Text = "Rolü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 61;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 32);
            this.label5.TabIndex = 63;
            this.label5.Text = "Şifre";
            // 
            // txtKayıtSifre
            // 
            this.txtKayıtSifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtSifre.Location = new System.Drawing.Point(187, 313);
            this.txtKayıtSifre.Name = "txtKayıtSifre";
            this.txtKayıtSifre.PasswordChar = '*';
            this.txtKayıtSifre.Size = new System.Drawing.Size(296, 30);
            this.txtKayıtSifre.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(91, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 32);
            this.label6.TabIndex = 67;
            this.label6.Text = "Soyad";
            // 
            // txtKayıtSoyad
            // 
            this.txtKayıtSoyad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtSoyad.Location = new System.Drawing.Point(187, 206);
            this.txtKayıtSoyad.Name = "txtKayıtSoyad";
            this.txtKayıtSoyad.Size = new System.Drawing.Size(296, 30);
            this.txtKayıtSoyad.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(127, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 32);
            this.label7.TabIndex = 65;
            this.label7.Text = "Ad";
            // 
            // txtKayıtAd
            // 
            this.txtKayıtAd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtAd.Location = new System.Drawing.Point(187, 154);
            this.txtKayıtAd.Name = "txtKayıtAd";
            this.txtKayıtAd.Size = new System.Drawing.Size(296, 30);
            this.txtKayıtAd.TabIndex = 64;
            // 
            // btnKayıtOnayla
            // 
            this.btnKayıtOnayla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnKayıtOnayla.Image = ((System.Drawing.Image)(resources.GetObject("btnKayıtOnayla.Image")));
            this.btnKayıtOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtOnayla.Location = new System.Drawing.Point(187, 419);
            this.btnKayıtOnayla.Name = "btnKayıtOnayla";
            this.btnKayıtOnayla.Size = new System.Drawing.Size(296, 70);
            this.btnKayıtOnayla.TabIndex = 68;
            this.btnKayıtOnayla.Text = "EKLE";
            this.btnKayıtOnayla.UseVisualStyleBackColor = true;
            this.btnKayıtOnayla.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbKullanıcıEkle
            // 
            this.chbKullanıcıEkle.AutoSize = true;
            this.chbKullanıcıEkle.BackColor = System.Drawing.Color.Transparent;
            this.chbKullanıcıEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbKullanıcıEkle.ForeColor = System.Drawing.Color.White;
            this.chbKullanıcıEkle.Location = new System.Drawing.Point(187, 370);
            this.chbKullanıcıEkle.Name = "chbKullanıcıEkle";
            this.chbKullanıcıEkle.Size = new System.Drawing.Size(132, 27);
            this.chbKullanıcıEkle.TabIndex = 71;
            this.chbKullanıcıEkle.Text = "Şifreyi Göster";
            this.chbKullanıcıEkle.UseVisualStyleBackColor = false;
            this.chbKullanıcıEkle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnKayıtOnayla);
            this.groupBox1.Controls.Add(this.chbKullanıcıEkle);
            this.groupBox1.Controls.Add(this.cmbKayitRol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKayıtKAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKayıtSifre);
            this.groupBox1.Controls.Add(this.txtKayıtSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtKayıtAd);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(51, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 577);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnKullaniciSil);
            this.groupBox2.Controls.Add(this.chbKullanıcıSilme);
            this.groupBox2.Controls.Add(this.kulSilAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.kulSilSifre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(681, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 301);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnKullaniciSil.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciSil.Image")));
            this.btnKullaniciSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciSil.Location = new System.Drawing.Point(193, 201);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(285, 65);
            this.btnKullaniciSil.TabIndex = 68;
            this.btnKullaniciSil.Text = "SİL";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // chbKullanıcıSilme
            // 
            this.chbKullanıcıSilme.AutoSize = true;
            this.chbKullanıcıSilme.BackColor = System.Drawing.Color.Transparent;
            this.chbKullanıcıSilme.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbKullanıcıSilme.ForeColor = System.Drawing.Color.White;
            this.chbKullanıcıSilme.Location = new System.Drawing.Point(193, 152);
            this.chbKullanıcıSilme.Name = "chbKullanıcıSilme";
            this.chbKullanıcıSilme.Size = new System.Drawing.Size(132, 27);
            this.chbKullanıcıSilme.TabIndex = 71;
            this.chbKullanıcıSilme.Text = "Şifreyi Göster";
            this.chbKullanıcıSilme.UseVisualStyleBackColor = false;
            this.chbKullanıcıSilme.CheckedChanged += new System.EventHandler(this.chbKullanıcıSilme_CheckedChanged);
            // 
            // kulSilAd
            // 
            this.kulSilAd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulSilAd.Location = new System.Drawing.Point(193, 48);
            this.kulSilAd.Name = "kulSilAd";
            this.kulSilAd.Size = new System.Drawing.Size(285, 30);
            this.kulSilAd.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 61;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // kulSilSifre
            // 
            this.kulSilSifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulSilSifre.Location = new System.Drawing.Point(193, 101);
            this.kulSilSifre.Name = "kulSilSifre";
            this.kulSilSifre.PasswordChar = '*';
            this.kulSilSifre.Size = new System.Drawing.Size(285, 30);
            this.kulSilSifre.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(114, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 32);
            this.label11.TabIndex = 63;
            this.label11.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 66);
            this.label1.TabIndex = 74;
            this.label1.Text = "Kullanıcı Ayarları Ekranı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(689, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 72;
            this.label8.Text = "Kullanıcı Silme";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(62, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "Kullanıcı Ekleme";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(689, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 23);
            this.label10.TabIndex = 76;
            this.label10.Text = "Ayarlar Giriş";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnAyarlarSifre);
            this.groupBox3.Controls.Add(this.chbAyarlarSifre);
            this.groupBox3.Controls.Add(this.txtAyarlarSifre);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(681, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 250);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            // 
            // btnAyarlarSifre
            // 
            this.btnAyarlarSifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAyarlarSifre.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlarSifre.Image")));
            this.btnAyarlarSifre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlarSifre.Location = new System.Drawing.Point(193, 143);
            this.btnAyarlarSifre.Name = "btnAyarlarSifre";
            this.btnAyarlarSifre.Size = new System.Drawing.Size(285, 65);
            this.btnAyarlarSifre.TabIndex = 68;
            this.btnAyarlarSifre.Text = "ONAYLA";
            this.btnAyarlarSifre.UseVisualStyleBackColor = true;
            this.btnAyarlarSifre.Click += new System.EventHandler(this.btnAyarlarSifre_Click);
            // 
            // chbAyarlarSifre
            // 
            this.chbAyarlarSifre.AutoSize = true;
            this.chbAyarlarSifre.BackColor = System.Drawing.Color.Transparent;
            this.chbAyarlarSifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbAyarlarSifre.ForeColor = System.Drawing.Color.White;
            this.chbAyarlarSifre.Location = new System.Drawing.Point(193, 94);
            this.chbAyarlarSifre.Name = "chbAyarlarSifre";
            this.chbAyarlarSifre.Size = new System.Drawing.Size(132, 27);
            this.chbAyarlarSifre.TabIndex = 71;
            this.chbAyarlarSifre.Text = "Şifreyi Göster";
            this.chbAyarlarSifre.UseVisualStyleBackColor = false;
            // 
            // txtAyarlarSifre
            // 
            this.txtAyarlarSifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAyarlarSifre.Location = new System.Drawing.Point(193, 43);
            this.txtAyarlarSifre.Name = "txtAyarlarSifre";
            this.txtAyarlarSifre.PasswordChar = '*';
            this.txtAyarlarSifre.Size = new System.Drawing.Size(285, 30);
            this.txtAyarlarSifre.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(114, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 32);
            this.label13.TabIndex = 63;
            this.label13.Text = "Şifre";
            // 
            // KullanıcıForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 787);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullanıcıForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKayitRol;
        private System.Windows.Forms.TextBox txtKayıtKAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKayıtSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKayıtSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKayıtAd;
        private System.Windows.Forms.Button btnKayıtOnayla;
        private System.Windows.Forms.CheckBox chbKullanıcıEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.CheckBox chbKullanıcıSilme;
        private System.Windows.Forms.TextBox kulSilAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kulSilSifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAyarlarSifre;
        private System.Windows.Forms.CheckBox chbAyarlarSifre;
        private System.Windows.Forms.TextBox txtAyarlarSifre;
        private System.Windows.Forms.Label label13;
    }
}