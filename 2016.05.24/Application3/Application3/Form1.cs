using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application3
{
    public partial class Form1 : Form
    {
        double c;
        String A1, A2;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            A1 = textBox1.Text.ToString();
            op = '+';
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            A1 = textBox1.Text.ToString();
            op = '-';
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            A1 = textBox1.Text.ToString();
            op = '*';
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            A1 = textBox1.Text.ToString();
            op = '/';
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            A2 = textBox1.Text.ToString();
            Calculation(A1, A2, op);
            label2.Text = A1 + op + A2;
            textBox1.Text = c.ToString();
        }

        public void Calculation(String a, String b, char operation)
        {
            if (a == "" || b == "")
            {
                label1.ForeColor = Color.Red;
                label1.Text = " Please check your inputs ";
            }
            else
            {
                double a1 = Convert.ToDouble(a);
                double b1 = Convert.ToDouble(b);

                switch (operation)
                {
                    case '+':
                        {
                            c = a1 + b1;
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
                    /*case '=':
                        {
                            textBox1.Text = c.ToString();
                            break;
                        }*/
                    default:
                        textBox1.Text = " Please check the operator ";
                        break;
                }
            }
          }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }
        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        }
        
        //private void button1_Click(object sender, EventArgs e)
        //{
         //   textBox1.Text = textBox1.Text + button1.Text;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            A1 = textBox1.Text.ToString();
            op = '+';
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            A1 = textBox1.Text.ToString();
            op = '-';
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            A1 = textBox1.Text.ToString();
            op = '*';
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            A2 = textBox1.Text.ToString();
            Calculation(A1, A2, op);
            label2.Text = A1 + op + A2;
            textBox1.Text = c.ToString();
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            A1 = textBox1.Text.ToString();
            op = '/';
            textBox1.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;
        }*/


    }
}
