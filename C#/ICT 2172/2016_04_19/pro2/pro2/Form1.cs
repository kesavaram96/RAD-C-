using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.button10.Text;
        }

        private void addb_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.addb.Text;
        }

        private void subb_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.subb.Text;
        }

        private void mulb_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.mulb.Text;
        }

        private void divb_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + this.divb.Text;
        }

        private void clrb_Click(object sender, EventArgs e)
        {
            tb.Text = null;
        }
    }
}