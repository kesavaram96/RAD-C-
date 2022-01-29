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

        public bool Name_required(String str)
        {
            if(str == "")
            {
                errorProvider1.SetError(Name_txt, "Please Enter your name !");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Name_required(Name_txt.Text);
        }
    }
}
