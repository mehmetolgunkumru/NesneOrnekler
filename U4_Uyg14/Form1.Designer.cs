
namespace U4_Uyg14
{
    partial class Form1
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
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.btnSıraCıkart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.Location = new System.Drawing.Point(12, 152);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(75, 23);
            this.btnSiraAl.TabIndex = 0;
            this.btnSiraAl.Text = "Sıra Al";
            this.btnSiraAl.UseVisualStyleBackColor = true;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSiraAl_Click);
            // 
            // btnSıraCıkart
            // 
            this.btnSıraCıkart.Location = new System.Drawing.Point(12, 181);
            this.btnSıraCıkart.Name = "btnSıraCıkart";
            this.btnSıraCıkart.Size = new System.Drawing.Size(75, 23);
            this.btnSıraCıkart.TabIndex = 1;
            this.btnSıraCıkart.Text = "Sıra Çıkart";
            this.btnSıraCıkart.UseVisualStyleBackColor = true;
            this.btnSıraCıkart.Click += new System.EventHandler(this.btnSıraCıkart_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(73, 134);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 209);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSıraCıkart);
            this.Controls.Add(this.btnSiraAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiraAl;
        private System.Windows.Forms.Button btnSıraCıkart;
        private System.Windows.Forms.ListBox listBox1;
    }
}

