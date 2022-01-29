using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Form3 F1;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            if(F1==null)
            {
                F1 = new Form3();
                F1.Show();
                //F1.MdiParent = this;
                F1.printAdd(a, b);
            }
            
        }

        Form2 F2;
        private void button2_Click(object sender, EventArgs e)
        {
            
          int a = int.Parse(textBox1.Text);
          int b = int.Parse(textBox2.Text);

          if (F2 == null)
          {
              F2 = new Form2();
              F2.Show();
              //F2.MdiParent = this;
              F2.printSub(a, b);
          }

            
        }
    }
}
