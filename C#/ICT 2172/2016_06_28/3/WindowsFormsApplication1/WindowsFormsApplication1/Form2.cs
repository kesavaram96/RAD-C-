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
        public Form2(String[,] A)
        {
            InitializeComponent();

            richTextBox1.Text = "Student Details\r\n\r\n";
            printStudents(A);
        }
        private void printStudents(String[,] A)
        {
            for(int i=0;i<A.GetLength(0);i++)
            {
                for(int j=0;j<A.GetLength(1);j++)
                {
                    richTextBox1.Text += A[i, j] + "\r\n";
                    if(j==0)
                    {
                        treeView1.Nodes.Add(A[i, j]);
                    }
                    else
                    {
                        treeView1.Nodes[i].Nodes.Add(A[i, j]);
                    }
                }
                richTextBox1.Text += ".....................\r\n";
            }
        }
    }
}
