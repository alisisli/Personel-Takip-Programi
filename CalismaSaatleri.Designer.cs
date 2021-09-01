
namespace Personel_Programı
{
    partial class CalismaSaatleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalismaSaatleri));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtGirisSaati = new System.Windows.Forms.TextBox();
            this.txtCikisSaati = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 48);
            this.label4.TabIndex = 36;
            this.label4.Text = "Giriş ve Çıkış Saatleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 48);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ayarlama Ekranı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 32);
            this.label7.TabIndex = 45;
            this.label7.Text = "Çıkış Saati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Giriş Saati";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnOnayla.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.Image")));
            this.btnOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnayla.Location = new System.Drawing.Point(218, 399);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(296, 70);
            this.btnOnayla.TabIndex = 49;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtGirisSaati
            // 
            this.txtGirisSaati.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisSaati.Location = new System.Drawing.Point(218, 221);
            this.txtGirisSaati.Name = "txtGirisSaati";
            this.txtGirisSaati.Size = new System.Drawing.Size(296, 30);
            this.txtGirisSaati.TabIndex = 63;
            // 
            // txtCikisSaati
            // 
            this.txtCikisSaati.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikisSaati.Location = new System.Drawing.Point(218, 287);
            this.txtCikisSaati.Name = "txtCikisSaati";
            this.txtCikisSaati.Size = new System.Drawing.Size(296, 30);
            this.txtCikisSaati.TabIndex = 64;
            // 
            // CalismaSaatleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 566);
            this.Controls.Add(this.txtGirisSaati);
            this.Controls.Add(this.txtCikisSaati);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalismaSaatleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışma Saatleri ";
            this.Load += new System.EventHandler(this.CalismaSaatleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtGirisSaati;
        private System.Windows.Forms.TextBox txtCikisSaati;
    }
}