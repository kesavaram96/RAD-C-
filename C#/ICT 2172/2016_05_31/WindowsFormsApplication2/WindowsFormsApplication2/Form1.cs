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
    public partial class Form1 : Form
    {
        string s, gender, CS;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ob_Click(object sender, EventArgs e)
        {
            
            if(pcb.Checked==true)
            {
                s = s + "," + pcb.Text;
            }
            if (scb.Checked == true)
            {
                s = s + "," + scb.Text;
            }
            if (dcb.Checked == true)
            {
                s = s + "," + dcb.Text;
            }
            if (secb.Checked == true)
            {
                s = s + "," + secb.Text;
            }

            if(mrb.Checked==true)
            {
                gender = mrb.Text;
            }
            if (frb.Checked == true)
            {
                gender = frb.Text;
            }

            if (mdrb.Checked == true)
            {
                CS = mdrb.Text;
            }
            if (srb.Checked == true)
            {
                CS = srb.Text;
            }

            srtb.Text = ("Name : " + ntb.Text + "\rAddress : "+artb.Text+"\rOccuption : "+s+"\rGender : "+gender+"\r\nCivil Status : "+CS+"\r\nAge : "+atb.Text);
        }
    }
}
