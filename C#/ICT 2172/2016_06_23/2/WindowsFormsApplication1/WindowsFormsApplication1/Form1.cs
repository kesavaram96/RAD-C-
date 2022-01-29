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
    public partial class Form1 : Form
    {
        int n = -1;
        String[,] A = new String[5, 5];

        public Form1()
        {
            InitializeComponent();
 
        }

        private void setdetail(String id,String na,String ge,String ag,String co,int n,String[,] A)
        {
            A[n, 0] = id;
            A[n, 1] = na;
            A[n, 2] = ge;
            A[n, 3] = ag;
            A[n, 4] = co;
        }

        private String printDetail(int n,String[,] A)
        {
            String text = "";
            for(int i=0;i<=n;i++)
            {
                for(int j=0;j<5;j++)
                {
                    text+= (A[i, j]);
                    text += "\n";
                }
                text += "\n\n";
            }
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n++;


            setdetail(textBox1.Text,textBox2.Text,,textBox3.Text,textBox4.Text,n,A);
            richTextBox1.Text = printDetail(n, A);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            string s = rd.Text;
        }
    }
}
