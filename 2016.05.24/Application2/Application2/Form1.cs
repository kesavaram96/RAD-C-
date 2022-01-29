using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application2
{
    public partial class Form1 : Form
    {
        double c;
        public Form1()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void Calculation(String a,String b,char operation)
        {
            if(a=="" || b=="")
            {
                label4.ForeColor = Color.Red;
                label4.Text = " Please check your inputs ";
            }
            else
            {
                double a1 = Convert.ToDouble(a);
                double b1 = Convert.ToDouble(b);

                switch(operation)
                {
                    case '+':
                        {
                            c=a1+b1;
                            break;
                        }
                   case '-':
                        {
                            c = a1 - b1;
                            break;
                        }
                   case '*':
                        {
                            c = a1 * b1;
                            break;
                        }
                   case '/':
                        {
                            c = a1 / b1;
                            break;
                        }
                    case '=':
                        {
                             textBox3.Text=c.ToString();
                            break;
                        }
                    default :
                        textBox3.Text = " Please check the operator ";
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, '+');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, '-');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, '*');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, '/');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, '=');
        }

        
    }


}
