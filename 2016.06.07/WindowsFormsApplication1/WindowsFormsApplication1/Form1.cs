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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
        }

        Form3 F1;
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(F1==null)
            {
                F1= new Form3();
                F1.MdiParent = this;
                F1.Show();
            }
            else
            {
                F1.Activate();
            }
        }

        private void asPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You saved as Pdf file ");
        }

        private void asDocxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You saved as docx file ");
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Saving is Successfull ");
        }
    }
}
