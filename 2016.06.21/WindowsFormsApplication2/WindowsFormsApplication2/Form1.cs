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
        public Form1()
        {
            InitializeComponent();
        }
        
        String B;
        public int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedItems.Count;
            for (int i = 0; i < a; i++)
            {
                String A = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(A);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
             

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = listBox2.SelectedItems.Count;
            for (int i = 0; i < a; i++)
            {
                B = listBox2.SelectedItem.ToString();
                listBox1.Items.Add(B);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
