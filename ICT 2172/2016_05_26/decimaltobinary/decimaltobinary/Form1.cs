using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decimaltobinary
{
    public partial class Form1 : Form
    {
        String output;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            //tb2.Text = rdtob(int.Parse(tb1.Text)).ToString();
            tb2.Text=rdtob2(int.Parse(tb1.Text));
        }

        public static int rdtob(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                int t = n % 2;
                return ((rdtob(n / 2) * 10) + t);
            }
        }

        public String rdtob2(int num)
        {
            int rem;
            if (num < 2)
            {
                output = num.ToString();
                return output;
            }
            else
            {
                if (num != 0)
                {
                    rdtob2(num / 2);
                    rem = num % 2;
                    output += rem.ToString();
                }
            }
            return output;
        }
    }
}