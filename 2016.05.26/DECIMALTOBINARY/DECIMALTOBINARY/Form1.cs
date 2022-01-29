using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DECIMALTOBINARY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Binary(int n)
        {
            String b1="";
            int b = 0;
            if (n == 0)
            {
                return "0";
            }
            else if (n == 1)
            {
                return "1";
            }
            else
            {
                if(n!=0)
                {
                    Binary(n / 2);
                    b = n % 2;
                    b1 += b.ToString();
                }
            }
            return b1;
        }
        public void BinaryToDecimal()
        {
            if (textBox1.Text == "0")
            {
                textBox2.Text = "0";
            }
            else if (textBox1.Text == "1")
            {
                textBox2.Text = "1";
            }
            else
            {
                int a = Convert.ToInt16(textBox1.Text);
                int a1 = a, i = 0;
                int count = 0;
                String st = "";
                while (a1 > 0)
                {
                    a1 = a1 / 10;
                    count++;
                }

                int[] b = new int[100];

                while (a > 0)
                {
                    b[i] = a % 2;
                    i++;
                    a = a / 2;
                }

                for (int j = i; j >= 0; j--)
                {
                    st += Convert.ToString(b[j]);
                }

                textBox2.Text = st;
            }
        }
        
        public void IpSplit(String a)
        {
            String[] a1 = a.Split('.');
            for(int i=0;i<a1.Length;i++)
            {
                int num = Convert.ToInt32(a1[i]);
                textBox2.Text+=
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = Binary(Convert.ToInt32(textBox1.Text));
            BinaryToDecimal();
        }
    }
}
