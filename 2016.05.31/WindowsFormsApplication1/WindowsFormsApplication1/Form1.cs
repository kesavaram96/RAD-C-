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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Welcome", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi "+textBox1.Text, "note", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
    }
}
