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
    public partial class MainForm : MetroForm
    {
        string s ;
        string s1;
        string s2;
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void CheckBoxChecking()
        {
            if (checkBox1.Checked == true)
            {
                s = s + "Programmer";
            }
            else if (checkBox2.Checked == true)
            {
                s = s + "Student";
            }
            else if (checkBox3.Checked == true)
            {
                s = s + "Developer";
            }
            else if (checkBox4.Checked == true)
            {
                s = s + "Software Engineer";
            }
        }

        public void GenderRadio()
        {
            if (radioButton1.Checked == true)
            {
                s1 = s1 + "Male";
            }
            else if (radioButton2.Checked == true)
            {
                s1 = s1 + "Female";
            }
        }

        public void CivilRadio()
        {
            if (radioButton3.Checked == true)
            {
                s2 = s2 + "Married";
            }
            else if (radioButton4.Checked == true)
            {
                s2 = s2 + "Single";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBoxChecking();
            GenderRadio();
            CivilRadio();
            //MessageBox.Show("Error", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            richTextBox1.Text = " Name :" + textBox1.Text + "\n Address : \n " + textBox2.Text + "\n Occupation : You are a " + s + "\n Gender : " + s1 + "\n Civil Status : " + s2 + "\n Your age is : " + textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help", "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
