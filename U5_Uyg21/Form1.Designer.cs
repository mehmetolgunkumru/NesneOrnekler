
namespace U5_Uyg21
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
            this.listeVeriler = new System.Windows.Forms.ListBox();
            this.btnVeriBagla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listeVeriler
            // 
            this.listeVeriler.FormattingEnabled = true;
            this.listeVeriler.Location = new System.Drawing.Point(78, 12);
            this.listeVeriler.Name = "listeVeriler";
            this.listeVeriler.Size = new System.Drawing.Size(120, 95);
            this.listeVeriler.TabIndex = 0;
            // 
            // btnVeriBagla
            // 
            this.btnVeriBagla.Location = new System.Drawing.Point(99, 124);
            this.btnVeriBagla.Name = "btnVeriBagla";
            this.btnVeriBagla.Size = new System.Drawing.Size(75, 23);
            this.btnVeriBagla.TabIndex = 1;
            this.btnVeriBagla.Text = "Veri Bağla";
            this.btnVeriBagla.UseVisualStyleBackColor = true;
            this.btnVeriBagla.Click += new System.EventHandler(this.btnVeriBagla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 164);
            this.Controls.Add(this.btnVeriBagla);
            this.Controls.Add(this.listeVeriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listeVeriler;
        private System.Windows.Forms.Button btnVeriBagla;
    }
}

