using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru6
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
    }
}
