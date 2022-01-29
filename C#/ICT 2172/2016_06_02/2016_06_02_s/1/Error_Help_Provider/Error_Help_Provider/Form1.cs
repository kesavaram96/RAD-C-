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

        public bool IndeNO_required(String str)
        {
            if (str == "")
            {
                errorProvider1.SetError(textBox2, "Please enter your index no!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        public bool Age_required(String str)
        {
            if (str == "")
            {
                errorProvider1.SetError(textBox3, "Please enter your age !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool Num_chk(String str)
        {
            bool hasletter = false;
            foreach(char c in str)
            {
                if(char.IsLetter(c))
                {
                    hasletter = true;
                    break;
                }
            }
            return hasletter;
        }

        private void sb_Click(object sender, EventArgs e)
        {
            Name_required(textBox1.Text);
            IndeNO_required(textBox2.Text);
            Age_required(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
