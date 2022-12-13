using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kucuksayı, buyuksayı;

                kucuksayı = Convert.ToInt32(textBox1.Text);

                buyuksayı = Convert.ToInt32(textBox2.Text);

                if (kucuksayı > buyuksayı)
                {
                    MessageBox.Show("Lütfen küçük sayı yerine küçük sayı giriniz");

                }
                else
                {
                    for (int i = kucuksayı; i < buyuksayı; i++)
                    {
                        if (i %2 == 0) 
                        {
                            listBox2.Items.Add(i);
                        }
                        else
                        {
                            listBox1.Items.Add(i);
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN SAYI GİRİNİZ");
            }
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

        }
        }
    }
