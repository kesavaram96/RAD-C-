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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool Name_required(string str)
        {
            if (str == "")
            {
                errorProvider1.SetError(nt, "Please enter your Name");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }

        }

        public bool IndexNo_required(string str)
        {
            if(str=="")//if(string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                errorProvider2.SetError(it, "Please enter your Index number");
                return false;
            }
            else
            {
                errorProvider2.Clear();
                return true;
            }

        }

        public bool Age_required(string str)
        {
            if (str == "")         //if(string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                errorProvider3.SetError(at, "Please enter your Age");
                return false;
            }
            else
            {
                errorProvider3.Clear();
                return true;
            }

        }

        public bool Age_Validation(string str)
        {
            if(Age_required(str))//if age textbox is not empty go for number check
            { 
                if(Num_chk(str))
                {
                     errorProvider3.SetError(at, "Age shoulde be number");
                    return false;
                }
                else 
                {
                    errorProvider3.Clear();
                    return true;
                }
            }
            else
            {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Name_required(nt.Text);
            IndexNo_required(it.Text);
            Age_Validation(nt.Text);
        }
    }
}
