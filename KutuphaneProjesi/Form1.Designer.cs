
namespace KutuphaneProjesi
{
    partial class formAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAnaSayfa));
            this.btnKıtap = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKıtap
            // 
            this.btnKıtap.Image = ((System.Drawing.Image)(resources.GetObject("btnKıtap.Image")));
            this.btnKıtap.Location = new System.Drawing.Point(40, 46);
            this.btnKıtap.Name = "btnKıtap";
            this.btnKıtap.Size = new System.Drawing.Size(170, 75);
            this.btnKıtap.TabIndex = 0;
            this.btnKıtap.Text = "Kitap İşlemleri";
            this.btnKıtap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKıtap.UseVisualStyleBackColor = true;
            this.btnKıtap.Click += new System.EventHandler(this.btnKıtap_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrenci.Image")));
            this.btnOgrenci.Location = new System.Drawing.Point(232, 46);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(170, 75);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = " Öğrenci İşlemleri";
            this.btnOgrenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnTur
            // 
            this.btnTur.Image = ((System.Drawing.Image)(resources.GetObject("btnTur.Image")));
            this.btnTur.Location = new System.Drawing.Point(40, 137);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(170, 75);
            this.btnTur.TabIndex = 2;
            this.btnTur.Text = "Tür İşlemleri";
            this.btnTur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTur.UseVisualStyleBackColor = true;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // btnOdunc
            // 
            this.btnOdunc.Image = ((System.Drawing.Image)(resources.GetObject("btnOdunc.Image")));
            this.btnOdunc.Location = new System.Drawing.Point(232, 137);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(170, 75);
            this.btnOdunc.TabIndex = 3;
            this.btnOdunc.Text = "Ödünç Kitap İşlemleri";
            this.btnOdunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // formAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKıtap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Kütüphane Projesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKıtap;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnOdunc;
    }
}

