using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro1
{
    public partial class cal : Form
    {
        public cal()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            tbr.Text =( int.Parse(tb1.Text) + int.Parse(tb2.Text)).ToString();
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            tbr.Text = (int.Parse(tb1.Text) - int.Parse(tb2.Text)).ToString();
        }

        private void MUL_Click(object sender, EventArgs e)
        {
            tbr.Text = (int.Parse(tb1.Text) * int.Parse(tb2.Text)).ToString();
        }

        private void DIV_Click(object sender, EventArgs e)
        {
            tbr.Text = (int.Parse(tb1.Text) / int.Parse(tb2.Text)).ToString();
        }
    }
}
