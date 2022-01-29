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
            listBox1.Items.Add(textBoxadd.Text);
            textBoxadd.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  textBox2.Text = listBox1.SelectedItem.ToString();
           // textBox2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();

            textBox3.Text = listBox1.Items.Count.ToString();
        }

        private void listBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }
    }
}
