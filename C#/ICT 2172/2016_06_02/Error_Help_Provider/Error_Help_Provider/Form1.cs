using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Help_Provider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool Name_required(String str)
        {
            if(str=="")
            {
                errorProvider1.SetError(textBox1, "Please enter your name !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private void sb_Click(object sender, EventArgs e)
        {
            Name_required(textBox1.Text);
        }
    }
}
