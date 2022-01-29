using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            //tb.Text = "Hello";
            //your textbox name.Text="..";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            tb.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            tb.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            tb.Text += "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            tb.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            tb.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            tb.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            tb.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            tb.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            tb.Text += "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            tb.Text += "0";
        }
    }
}
