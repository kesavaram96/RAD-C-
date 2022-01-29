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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void print(string [,]st)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    listBox1.Items.Add(st[i, j]);
                    if(i==0)
                    {
                        treeView1.Nodes.Add(st[i, j]);
                    }
                    
                    else
                    {
                         treeView1.Nodes[j].Nodes.Add(st[i, j]);
                    }
                }
                //listBox1.Items.Add("\n");

            }
        }

        /*
         public void PrintStudents(string [,]st)
         * {
         *  richTextBox1.Text+=st[i,j]+"\n";
         *  if(i==0)
                    {
                        treeView1.Nodes.Add(st[i, j]);
                    }
                    
                    else
                    {
                         treeView1.Nodes[j].Nodes.Add(st[i, j]);
                    }
         * }
         */
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    
    
}
