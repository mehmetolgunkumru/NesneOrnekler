
namespace U5_Uyg6
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
            this.AnaMenu = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.AnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaMenu
            // 
            this.AnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDuzen,
            this.menuCikis});
            this.AnaMenu.Location = new System.Drawing.Point(0, 0);
            this.AnaMenu.Name = "AnaMenu";
            this.AnaMenu.Size = new System.Drawing.Size(350, 24);
            this.AnaMenu.TabIndex = 0;
            this.AnaMenu.Text = "menuStrip1";
            // 
            // menuDosya
            // 
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuDuzen
            // 
            this.menuDuzen.Name = "menuDuzen";
            this.menuDuzen.Size = new System.Drawing.Size(52, 20);
            this.menuDuzen.Text = "Düzen";
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(44, 20);
            this.menuCikis.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.AnaMenu);
            this.MainMenuStrip = this.AnaMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.AnaMenu.ResumeLayout(false);
            this.AnaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AnaMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuDuzen;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
    }
}

