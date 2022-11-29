using System;
using System.Windows.Forms;

namespace U2_GoldSoru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Random random = new Random();
                pictureBox1.Left = pictureBox1.Left + random.Next(1, 20);
                pictureBox2.Left = pictureBox2.Left + random.Next(1, 20);
            }
        }
    }
}
