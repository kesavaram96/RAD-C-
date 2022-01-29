using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validateregnumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Char_chk(String str)
        {
            bool hasDigit = false;
            foreach(char c in str)
            {
                if(char.IsDigit(c))
                {
                    hasDigit = true;
                    break;
                }
            }
            return hasDigit;
        }

        private bool Length_chk(String str,int len)
        {
            if(str.Length==len)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IndeNO_required(String str)
        {
            if (str == "")//if(String.IsNullOrEmpty(str)||String.IsNullOrWhiteSpace(str))
            {
                errorProvider1.SetError(tb, "Please enter your index no!");
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
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    hasletter = true;
                    break;
                }
            }
            return hasletter;
        }

        public bool Indexnum_validation(String str)
        {
            if(IndeNO_required(str))
            {
                if(!Length_chk(str,11))
                {
                    errorProvider1.SetError(tb,"Please check your index number");
                    return false;
                }
                else
                {
                    errorProvider1.Clear();
                    String indexnum = str;
                    String[] arr = indexnum.Split('/');
                    if(Num_chk(arr[0]) || Char_chk(arr[1]) || Num_chk(arr[2]))
                    {
                        errorProvider1.SetError(tb, "Please check your index number");
                        return false;
                    }
                    else
                    {
                        errorProvider1.Clear();
                        return true;
                    }
                }
            }
        }

        private void vb_Click(object sender, EventArgs e)
        {
            Indexnum_validation(tb.Text);
        }

        private void Set_Help_provider()
        {
            helpProvider1.SetShowHelp(tb, true);
            helpProvider1.SetHelpString(tb, "sample index number format 2013/ict/01");
        }
    }
}
