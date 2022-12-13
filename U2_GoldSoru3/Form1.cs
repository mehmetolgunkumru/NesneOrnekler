using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMat_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";

        }

        private void rbTürkçe_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
        }

        private void rbNesne_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
        }

        private void rbRobotik_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, ortalama;
            not1 = Convert.ToInt16(txtNot1.Text);
            not2 = Convert.ToInt16(txtNot2.Text);
            not3 = Convert.ToInt16(txtNot3.Text);
            ortalama = (not1) + (not2) + (not3);
            label5.Text.ToString();
            {

            }
            if (rbMat.Checked)
            {
                label4.Text = "Matematik ortalaması";
            }
           else if (rbTürkçe.Checked)
            {
                label4.Text = "Türkçe ortalaması";
            }
           else if (rbNesne.Checked)
            {
                label4.Text = "Nesne Tabanlı Prog ortalaması";
            }
           else if (rbRobotik.Checked)
            {
                label4.Text = "Robotik Kodlama ortalaması";
            }
            else
            {

            }
        }
    }
    }
  
