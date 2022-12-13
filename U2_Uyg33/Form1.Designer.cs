namespace U2_Uyg33
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Giris = new System.Windows.Forms.Button();
            this.txtkuladi = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Giris
            // 
            this.button_Giris.Location = new System.Drawing.Point(94, 171);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(100, 23);
            this.button_Giris.TabIndex = 0;
            this.button_Giris.Text = "Giriş";
            this.button_Giris.UseVisualStyleBackColor = true;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // txtkuladi
            // 
            this.txtkuladi.AutoSize = true;
            this.txtkuladi.Location = new System.Drawing.Point(12, 68);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(64, 13);
            this.txtkuladi.TabIndex = 1;
            this.txtkuladi.Text = "Kullanıcı Adı";
            // 
            // txtsifre
            // 
            this.txtsifre.AutoSize = true;
            this.txtsifre.Location = new System.Drawing.Point(12, 125);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(76, 13);
            this.txtsifre.TabIndex = 2;
            this.txtsifre.Text = "kullanıcı Şifresi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkuladi);
            this.Controls.Add(this.button_Giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.Label txtkuladi;
        private System.Windows.Forms.Label txtsifre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

