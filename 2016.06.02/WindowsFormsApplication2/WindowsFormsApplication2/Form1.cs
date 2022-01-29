using MetroFramework.Forms;
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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Set_Help_provider();
        }

        public bool Name_required(String str)
        {
            if (str == "")
            {
                errorProvider1.SetError(Name_txt, "Please Enter your name !");
                return false;
            }

            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        public bool Index_required(String str)
        {
            if (str == "")
            {
                errorProvider2.SetError(Index_txt, "Please Enter your index no !");
                return false;
            }

            else
            {
                bool e = false;
                if (Index_check(str) == false)
                {
                    errorProvider2.SetError(Index_txt, "Please Enter your correct index no !");
                    e=false;
                }
                else
                {
                    errorProvider2.Clear();
                    e=true;
                }
                return e;
            }
        }

        public bool Age_required(String str)
        {
            if (str == "")
            {
                errorProvider3.SetError(Age_txt, "Please Enter your age !");
                return false;
            }
            
            else
            {
                Boolean b = false;
          
                if(Num_check(str)==true)
                {
                    errorProvider3.SetError(Age_txt, "Please Enter your correct age !");
                    b = false;
                }
                else
                {
                    errorProvider3.Clear();
                    b = true;
                }

                return b;
            }
        }

        private bool Num_check(String str)
        {
            bool hasLetter=false;
            foreach(char c in str)
            {
                if(char.IsLetter(c))
                {
                    hasLetter=true;
                    break;
                }
            
            }
            return hasLetter;
        }

        private bool Char_check(String str)
        {
            bool hasLetter = false;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    hasLetter = true;
                    break;
                }

            }
            return hasLetter;
        }


       private bool Index_check(String str)
        {
           bool b=false;
            if(str.Length!=11)
            {
      
                b=false;
            }
            else
            {
                //errorProvider2.Clear();
                String index=str;
                String [] arr=index.Split('/');

                if(Num_check(arr[0]) || Char_check(arr[1]) || Num_check(arr[2]))
                {
	                //errorProvider2.SetError(Index_txt, "Please Enter your correct index no !");
	                b=false;
                }
                else
                {
	                //errorProvider2.Clear();
	                b=true;
                }
            }
           return b;
        }


        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Name_required(Name_txt.Text);
            Index_required(Index_txt.Text);
            Age_required(Age_txt.Text);
        }

        private void Set_Help_provider()
        {
            helpProvider1.SetShowHelp(Name_txt, true);
            helpProvider1.SetHelpString(Name_txt, "You can enter your full Name");
        }
    }
}
