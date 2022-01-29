using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro1
{
    public partial class cal : Form
    {
        public cal()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            //check the input values is it empty or not
            if(tb1.Text==""&& tb2.Text=="")
            {
                tbr.Text = "Please check your inputs";
            }
            else
            {
                //convert text(string) to double
                double a = Convert.ToDouble(tb1.Text);
                double b = Convert.ToDouble(tb2.Text);
                double output = a + b;
                //Convert double to string
                tbr.Text = output.ToString();
            }
        }
           

        private void SUB_Click(object sender, EventArgs e)
        {
            //check the input values is it empty or not
            if (tb1.Text == "" && tb2.Text == "")
            {
                tbr.Text = "Please check your inputs";
            }
            else
            {
                //convert text(string) to double
                double a = Convert.ToDouble(tb1.Text);
                double b = Convert.ToDouble(tb2.Text);
                double output = a - b;
                //Convert double to string
                tbr.Text = output.ToString();
            }
        }

        private void MUL_Click(object sender, EventArgs e)
        {
            //check the input values is it empty or not
            if (tb1.Text == "" && tb2.Text == "")
            {
                tbr.Text = "Please check your inputs";
            }
            else
            {
                //convert text(string) to double
                double a = Convert.ToDouble(tb1.Text);
                double b = Convert.ToDouble(tb2.Text);
                double output = a * b;
                //Convert double to string
                tbr.Text = output.ToString();
            }
        }

        private void DIV_Click(object sender, EventArgs e)
        {
            //check the input values is it empty or not
            if (tb1.Text == "" && tb2.Text == "")
            {
                tbr.Text = "Please check your inputs";
            }
            else
            {
                //convert text(string) to double
                double a = Convert.ToDouble(tb1.Text);
                double b = Convert.ToDouble(tb2.Text);
                double output = a / b;
                //Convert double to string
                tbr.Text = output.ToString();
            }
        }
    }
}
