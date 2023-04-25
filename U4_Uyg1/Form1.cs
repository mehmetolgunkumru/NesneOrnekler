using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                isimler[index] = textBox1.Text;
                index++;
                textBox1.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("yavaşş   ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fo
            }
            catch (Exception)
            {
                MessageBox.Show("Eleman sayısında eksik var");
            }
        }
    }
}
