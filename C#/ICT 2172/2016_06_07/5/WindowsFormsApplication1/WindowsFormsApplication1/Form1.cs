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
        public Form1()
        {
            InitializeComponent();
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            String n = textBox1.Text;
            int ag = int.Parse(textBox2.Text);
            String ad = textBox3.Text;

            Form2 ob = new Form2(n, ag, ad);
            ob.Show();
        }
    }
}
