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
        string [,]Student_Details;
        public Form1()
        {
            InitializeComponent();
            Student_Details=new string[5,5];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Set_TextBox1(int i)
        {
          
                Student_Details[0, i] = textBox1.Text;
                textBox1.Text = "";
        }

        private void Set_TextBox2(int i)
        {
            
                Student_Details[1, i] = textBox2.Text;
                textBox2.Text = "";
           
        }

        private void Set_TextBox3(int i)
        {
            
                if (radioButton1.Checked==true)
                {
                    Student_Details[2, i] = radioButton1.Text;
                }
                else
                {
                    Student_Details[2, i] = radioButton2.Text;
                }
            
        }

        private void Set_TextBox4(int i)
        {
            
                Student_Details[3, i] = textBox3.Text;
                textBox3.Text = "";
            
        }

        private void Set_TextBox5(int i)
        {
          
                Student_Details[4, i] = textBox4.Text;
                textBox4.Text = "";
            
        }
        int a = 0;
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if(count==5)
            {
                button1.Enabled=false;
            }
           
                Set_TextBox1(a);
                Set_TextBox2(a);
                Set_TextBox3(a);
                Set_TextBox4(a);
                Set_TextBox5(a);
                a++;
                count++;
            
            
            
        }
        Form2 F2;
        private void button2_Click(object sender, EventArgs e)
        {
            F2=new Form2();
            this.Hide();
            F2.Show();

            F2.print(Student_Details);
          
                    
             
            


        }
    }
}
