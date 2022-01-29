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
             Calculation(tb1.Text,tb2.Text,'+');
        }

        private void SUB_Click(object sender, EventArgs e)
        {
           Calculation(tb1.Text,tb2.Text,'-');
        }

        private void MUL_Click(object sender, EventArgs e)
        {
           Calculation(tb1.Text,tb2.Text,'*');
        }

        private void DIV_Click(object sender, EventArgs e)
        {
           Calculation(tb1.Text,tb2.Text,'/');
        }

        public void Calculation(String a, String b, char operation)
        {
            if (a == "" || b == "")
            {
                tbr.ForeColor = System.Drawing.Color.Red;
                tbr.Text = "Please check your inputs";
            }
            else
            {
                double n1 = Convert.ToDouble(a);
                double n2 = Convert.ToDouble(b);
                double output = 0.0;
                switch (operation)
                {
                    case '+':
                        {
                            output = n1 + n2;
                            break;
                        }
                    case '-':
                        {
                            output = n1 - n2;
                            break;
                        }
                    case '*':
                        {
                            output = n1 * n2;
                            break;
                        }
                    case '/':
                        {
                            output = n1 / n2;
                            break;
                        }
                    default:
                        {
                            tbr.Text = "Error";
                            break;
                        }
                }
                tbr.ForeColor = System.Drawing.Color.Green;
                tbr.Text = output.ToString();
            }
        }
    }
}
