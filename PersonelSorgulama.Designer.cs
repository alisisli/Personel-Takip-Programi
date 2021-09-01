
namespace Personel_Programı
{
    partial class PersonelSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelSorgulama));
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSorgulamaCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpSorgulamadTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSorgulamaSoyisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSorgulamaİsim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSorgulamaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSorgulamaTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPersonelSorgula = new System.Windows.Forms.DataGridView();
            this.cmbSorgulamaRol = new System.Windows.Forms.ComboBox();
            this.cmbSorgulamaDepartman = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonelSorgula)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(9)))));
            this.label11.Location = new System.Drawing.Point(746, 803);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 38);
            this.label11.TabIndex = 55;
            this.label11.Text = "Design";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(622, 803);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 38);
            this.label12.TabIndex = 54;
            this.label12.Text = "DebiAl";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(115, 565);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(404, 75);
            this.btnSil.TabIndex = 52;
            this.btnSil.Text = "SIL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(74, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 32);
            this.label9.TabIndex = 51;
            this.label9.Text = "Departman";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(109, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 32);
            this.label8.TabIndex = 49;
            this.label8.Text = "Cinsiyet";
            // 
            // cmbSorgulamaCinsiyet
            // 
            this.cmbSorgulamaCinsiyet.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cmbSorgulamaCinsiyet.FormattingEnabled = true;
            this.cmbSorgulamaCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbSorgulamaCinsiyet.Location = new System.Drawing.Point(223, 500);
            this.cmbSorgulamaCinsiyet.Name = "cmbSorgulamaCinsiyet";
            this.cmbSorgulamaCinsiyet.Size = new System.Drawing.Size(296, 31);
            this.cmbSorgulamaCinsiyet.TabIndex = 48;
            // 
            // dtpSorgulamadTarihi
            // 
            this.dtpSorgulamadTarihi.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpSorgulamadTarihi.Location = new System.Drawing.Point(223, 451);
            this.dtpSorgulamadTarihi.Name = "dtpSorgulamadTarihi";
            this.dtpSorgulamadTarihi.Size = new System.Drawing.Size(296, 30);
            this.dtpSorgulamadTarihi.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(115, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 32);
            this.label5.TabIndex = 45;
            this.label5.Text = "D.Tarihi";
            // 
            // txtSorgulamaSoyisim
            // 
            this.txtSorgulamaSoyisim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorgulamaSoyisim.Location = new System.Drawing.Point(223, 403);
            this.txtSorgulamaSoyisim.Name = "txtSorgulamaSoyisim";
            this.txtSorgulamaSoyisim.Size = new System.Drawing.Size(296, 30);
            this.txtSorgulamaSoyisim.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(111, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 43;
            this.label6.Text = "Soyisim";
            // 
            // txtSorgulamaİsim
            // 
            this.txtSorgulamaİsim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorgulamaİsim.Location = new System.Drawing.Point(223, 355);
            this.txtSorgulamaİsim.Name = "txtSorgulamaİsim";
            this.txtSorgulamaİsim.Size = new System.Drawing.Size(296, 30);
            this.txtSorgulamaİsim.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(150, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 32);
            this.label7.TabIndex = 41;
            this.label7.Text = "İsim";
            // 
            // txtSorgulamaNo
            // 
            this.txtSorgulamaNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorgulamaNo.Location = new System.Drawing.Point(223, 209);
            this.txtSorgulamaNo.Name = "txtSorgulamaNo";
            this.txtSorgulamaNo.Size = new System.Drawing.Size(296, 30);
            this.txtSorgulamaNo.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "Numara";
            // 
            // txtSorgulamaTc
            // 
            this.txtSorgulamaTc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorgulamaTc.Location = new System.Drawing.Point(223, 306);
            this.txtSorgulamaTc.Name = "txtSorgulamaTc";
            this.txtSorgulamaTc.Size = new System.Drawing.Size(296, 30);
            this.txtSorgulamaTc.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rolü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(414, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(701, 66);
            this.label4.TabIndex = 35;
            this.label4.Text = "Personel Sorgulama Ekranı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(115, 676);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(404, 75);
            this.btnGuncelle.TabIndex = 56;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cinsiyet
            // 
            this.cinsiyet.HeaderText = "Cinsiyet";
            this.cinsiyet.MinimumWidth = 6;
            this.cinsiyet.Name = "cinsiyet";
            // 
            // dtarihi
            // 
            this.dtarihi.HeaderText = "D.Tarihi";
            this.dtarihi.MinimumWidth = 6;
            this.dtarihi.Name = "dtarihi";
            // 
            // soyisim
            // 
            this.soyisim.HeaderText = "Soyisim";
            this.soyisim.MinimumWidth = 6;
            this.soyisim.Name = "soyisim";
            // 
            // isim
            // 
            this.isim.HeaderText = "İsim";
            this.isim.MinimumWidth = 6;
            this.isim.Name = "isim";
            // 
            // tc
            // 
            this.tc.HeaderText = "TC";
            this.tc.MinimumWidth = 6;
            this.tc.Name = "tc";
            // 
            // departman
            // 
            this.departman.HeaderText = "Departman";
            this.departman.MinimumWidth = 6;
            this.departman.Name = "departman";
            // 
            // no
            // 
            this.no.HeaderText = "Numara";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            // 
            // rol
            // 
            this.rol.HeaderText = "Rolü";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            // 
            // dtgPersonelSorgula
            // 
            this.dtgPersonelSorgula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPersonelSorgula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonelSorgula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rol,
            this.no,
            this.departman,
            this.tc,
            this.isim,
            this.soyisim,
            this.dtarihi,
            this.cinsiyet});
            this.dtgPersonelSorgula.Location = new System.Drawing.Point(601, 161);
            this.dtgPersonelSorgula.Name = "dtgPersonelSorgula";
            this.dtgPersonelSorgula.RowHeadersWidth = 51;
            this.dtgPersonelSorgula.RowTemplate.Height = 24;
            this.dtgPersonelSorgula.Size = new System.Drawing.Size(778, 590);
            this.dtgPersonelSorgula.TabIndex = 53;
            this.dtgPersonelSorgula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPersonelSorgula_CellDoubleClick);
            // 
            // cmbSorgulamaRol
            // 
            this.cmbSorgulamaRol.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cmbSorgulamaRol.FormattingEnabled = true;
            this.cmbSorgulamaRol.Items.AddRange(new object[] {
            "Yönetici",
            "Personel"});
            this.cmbSorgulamaRol.Location = new System.Drawing.Point(223, 161);
            this.cmbSorgulamaRol.Name = "cmbSorgulamaRol";
            this.cmbSorgulamaRol.Size = new System.Drawing.Size(296, 31);
            this.cmbSorgulamaRol.TabIndex = 57;
            // 
            // cmbSorgulamaDepartman
            // 
            this.cmbSorgulamaDepartman.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cmbSorgulamaDepartman.FormattingEnabled = true;
            this.cmbSorgulamaDepartman.Items.AddRange(new object[] {
            "Grafik Tasarım",
            "Back-End ",
            "Front-End",
            "Siber Güvenlik"});
            this.cmbSorgulamaDepartman.Location = new System.Drawing.Point(223, 257);
            this.cmbSorgulamaDepartman.Name = "cmbSorgulamaDepartman";
            this.cmbSorgulamaDepartman.Size = new System.Drawing.Size(296, 31);
            this.cmbSorgulamaDepartman.TabIndex = 58;
            // 
            // PersonelSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1453, 868);
            this.Controls.Add(this.cmbSorgulamaDepartman);
            this.Controls.Add(this.cmbSorgulamaRol);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgPersonelSorgula);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSorgulamaCinsiyet);
            this.Controls.Add(this.dtpSorgulamadTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSorgulamaSoyisim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSorgulamaİsim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSorgulamaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSorgulamaTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PersonelSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelSorgulama";
            this.Load += new System.EventHandler(this.PersonelSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonelSorgula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSorgulamaCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpSorgulamadTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSorgulamaSoyisim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSorgulamaİsim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSorgulamaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSorgulamaTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridView dtgPersonelSorgula;
        private System.Windows.Forms.ComboBox cmbSorgulamaRol;
        private System.Windows.Forms.ComboBox cmbSorgulamaDepartman;
    }
}