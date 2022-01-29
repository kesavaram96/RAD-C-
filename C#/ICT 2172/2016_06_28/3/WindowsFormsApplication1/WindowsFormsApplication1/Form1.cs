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

        int i;
        String[,] A = new String[5, 5]; 

        public Form1()
        {
            InitializeComponent();
 
        }

        private String setdetail(int i,String id,String na,String ge,String ag,String co)
        {
            A[i, 0] = id;
            A[i, 1] = na;
            A[i, 2] = ge;
            A[i, 3] = ag;
            A[i, 4] = co;

            return ".\r\n" + id + ".\r\n" + na + ".\r\n" + ge + ".\r\n" + ag + ".\r\n" + co + ".\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String gen = "";
            if(i<5)
            {
                if (radioButton1.Checked)
                    gen = "Male";
                if (radioButton2.Checked)
                    gen = "Femele";
            
                richTextBox1.Text+=setdetail(i,textBox1.Text, textBox2.Text,gen, textBox3.Text, textBox4.Text);
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                i++;
                label7.Text=i.ToString();
            }
            if(i==5)
            {
                button2.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2(A);
            fm2.Show();
        }
    }
}
