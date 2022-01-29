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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void printName(String a)
        {
            label1.Text = " Your Name is : " + a;
        }

        public void printAge(int a)
        {
            label2.Text = " Your Age is : " + a.ToString();
        }

        public void printAddress(String a)
        {
            label3.Text = " Your Address is : \n " + a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
