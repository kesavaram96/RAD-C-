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
        string a, b;
        char operation;
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

        private void c_Click(object sender, EventArgs e)
        {
            tb.Text = null;
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            operation = '+';
            a = tb.Text;
            tb.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if(tb.Text=="")
                tb.Text += "0.";
            else
                tb.Text += ".";
        }

        private void mul_btn_Click(object sender, EventArgs e)
        {
            operation = '*';
            a=tb.Text;
            tb.Text="";
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            operation = '-';
            a = tb.Text;
            tb.Text = "";
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            operation = '/';
            a = tb.Text;
            tb.Text = "";
        }

        private void eq_btn_Click(object sender, EventArgs e)
        {
            b = tb.Text;
            Calculation(a, b, operation);
            
        }
        public void Calculation(String a, String b, char operation)
        {
            if (a == "" || b == "")
            {
                tb.ForeColor = System.Drawing.Color.Red;
                tb.Text = "Please check your inputs";
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
                            tb.Text = "Error";
                            break;
                        }
                }
                tb.ForeColor = System.Drawing.Color.Green;
                tb.Text = output.ToString();
            }
        }
    }
}
//tbr.Text = (int.Parse(tb1.Text) - int.Parse(tb2.Text)).ToString();