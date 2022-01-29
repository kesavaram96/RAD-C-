using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 F;

        private void button1_Click(object sender, EventArgs e)
        {
            if(F==null)
            {
                F = new Form2();
                int a = int.Parse(textBox2.Text);
                F.printName(textBox1.Text);
                F.printAge(a);
                F.printAddress(textBox3.Text);
                F.Show();
            }
            else
            {
                F.Activate();
            }
        }
    }
}
