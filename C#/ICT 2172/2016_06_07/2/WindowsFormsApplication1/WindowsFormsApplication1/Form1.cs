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

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        Form2 ob;
        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ob==null)
            {
                ob=new Form2();
                ob.MdiParent = this;  // and figure 1
                ob.Show();
            }
            else
            {
                ob.Activate();
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ob2 = new Form3();
            ob2.MdiParent = this; // and figure 1
            ob2.Show();
        }
    }
}
