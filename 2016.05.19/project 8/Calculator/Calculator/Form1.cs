using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
            textBox1.Text = "heyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void btc_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            i=i%10;
            textBox1.Text = i.ToString();
        }
    }
}
