namespace U2_GoldSoru3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRobotik = new System.Windows.Forms.RadioButton();
            this.rbNesne = new System.Windows.Forms.RadioButton();
            this.rbTürkçe = new System.Windows.Forms.RadioButton();
            this.rbMat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.btnHesaplama = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRobotik);
            this.groupBox1.Controls.Add(this.rbNesne);
            this.groupBox1.Controls.Add(this.rbTürkçe);
            this.groupBox1.Controls.Add(this.rbMat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dersler";
            // 
            // rbRobotik
            // 
            this.rbRobotik.AutoSize = true;
            this.rbRobotik.Location = new System.Drawing.Point(6, 130);
            this.rbRobotik.Name = "rbRobotik";
            this.rbRobotik.Size = new System.Drawing.Size(106, 17);
            this.rbRobotik.TabIndex = 3;
            this.rbRobotik.TabStop = true;
            this.rbRobotik.Text = "Robotik Kodlama";
            this.rbRobotik.UseVisualStyleBackColor = true;
            this.rbRobotik.CheckedChanged += new System.EventHandler(this.rbRobotik_CheckedChanged);
            // 
            // rbNesne
            // 
            this.rbNesne.AutoSize = true;
            this.rbNesne.Location = new System.Drawing.Point(6, 89);
            this.rbNesne.Name = "rbNesne";
            this.rbNesne.Size = new System.Drawing.Size(140, 17);
            this.rbNesne.TabIndex = 2;
            this.rbNesne.TabStop = true;
            this.rbNesne.Text = "Nesne Tabanlı proglama";
            this.rbNesne.UseVisualStyleBackColor = true;
            this.rbNesne.CheckedChanged += new System.EventHandler(this.rbNesne_CheckedChanged);
            // 
            // rbTürkçe
            // 
            this.rbTürkçe.AutoSize = true;
            this.rbTürkçe.Location = new System.Drawing.Point(6, 52);
            this.rbTürkçe.Name = "rbTürkçe";
            this.rbTürkçe.Size = new System.Drawing.Size(59, 17);
            this.rbTürkçe.TabIndex = 1;
            this.rbTürkçe.TabStop = true;
            this.rbTürkçe.Text = "Türkçe";
            this.rbTürkçe.UseVisualStyleBackColor = true;
            this.rbTürkçe.CheckedChanged += new System.EventHandler(this.rbTürkçe_CheckedChanged);
            // 
            // rbMat
            // 
            this.rbMat.AutoSize = true;
            this.rbMat.Location = new System.Drawing.Point(6, 19);
            this.rbMat.Name = "rbMat";
            this.rbMat.Size = new System.Drawing.Size(74, 17);
            this.rbMat.TabIndex = 0;
            this.rbMat.TabStop = true;
            this.rbMat.Text = "Matematik";
            this.rbMat.UseVisualStyleBackColor = true;
            this.rbMat.CheckedChanged += new System.EventHandler(this.rbMat_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNot1);
            this.groupBox2.Controls.Add(this.txtNot2);
            this.groupBox2.Controls.Add(this.txtNot3);
            this.groupBox2.Controls.Add(this.btnHesaplama);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(234, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 218);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesaplama";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(74, 16);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(100, 20);
            this.txtNot1.TabIndex = 1;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(74, 49);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(100, 20);
            this.txtNot2.TabIndex = 2;
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(74, 92);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(100, 20);
            this.txtNot3.TabIndex = 3;
            // 
            // btnHesaplama
            // 
            this.btnHesaplama.Location = new System.Drawing.Point(9, 189);
            this.btnHesaplama.Name = "btnHesaplama";
            this.btnHesaplama.Size = new System.Drawing.Size(171, 23);
            this.btnHesaplama.TabIndex = 5;
            this.btnHesaplama.Text = "button1";
            this.btnHesaplama.UseVisualStyleBackColor = true;
            this.btnHesaplama.Click += new System.EventHandler(this.btnHesaplama_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazılı 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazılı 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazılı 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 237);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRobotik;
        private System.Windows.Forms.RadioButton rbNesne;
        private System.Windows.Forms.RadioButton rbTürkçe;
        private System.Windows.Forms.RadioButton rbMat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtNot3;
        private System.Windows.Forms.Button btnHesaplama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

