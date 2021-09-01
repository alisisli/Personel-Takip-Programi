
namespace Personel_Programı
{
    partial class AyarlarSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyarlarSifre));
            this.btnAyarlarSifre = new System.Windows.Forms.Button();
            this.chbAyarlarSifre = new System.Windows.Forms.CheckBox();
            this.txtAyarlarSifre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAyarlarSifre
            // 
            this.btnAyarlarSifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAyarlarSifre.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlarSifre.Image")));
            this.btnAyarlarSifre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlarSifre.Location = new System.Drawing.Point(101, 167);
            this.btnAyarlarSifre.Name = "btnAyarlarSifre";
            this.btnAyarlarSifre.Size = new System.Drawing.Size(285, 65);
            this.btnAyarlarSifre.TabIndex = 74;
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
            this.chbAyarlarSifre.Location = new System.Drawing.Point(101, 125);
            this.chbAyarlarSifre.Name = "chbAyarlarSifre";
            this.chbAyarlarSifre.Size = new System.Drawing.Size(132, 27);
            this.chbAyarlarSifre.TabIndex = 75;
            this.chbAyarlarSifre.Text = "Şifreyi Göster";
            this.chbAyarlarSifre.UseVisualStyleBackColor = false;
            this.chbAyarlarSifre.CheckedChanged += new System.EventHandler(this.chbAyarlarSifre_CheckedChanged);
            // 
            // txtAyarlarSifre
            // 
            this.txtAyarlarSifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAyarlarSifre.Location = new System.Drawing.Point(101, 77);
            this.txtAyarlarSifre.Name = "txtAyarlarSifre";
            this.txtAyarlarSifre.PasswordChar = '*';
            this.txtAyarlarSifre.Size = new System.Drawing.Size(285, 30);
            this.txtAyarlarSifre.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(207, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 32);
            this.label13.TabIndex = 73;
            this.label13.Text = "Şifre";
            // 
            // AyarlarSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(489, 272);
            this.Controls.Add(this.btnAyarlarSifre);
            this.Controls.Add(this.chbAyarlarSifre);
            this.Controls.Add(this.txtAyarlarSifre);
            this.Controls.Add(this.label13);
            this.Name = "AyarlarSifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar Ekranına Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyarlarSifre;
        private System.Windows.Forms.CheckBox chbAyarlarSifre;
        private System.Windows.Forms.TextBox txtAyarlarSifre;
        private System.Windows.Forms.Label label13;
    }
}