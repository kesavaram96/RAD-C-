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
    public partial class AddForm : Form
    {
        public AddForm(int a,int b)
        {
            InitializeComponent();
            int x = a;
            int y = b;
            int z = x + y;
            Sum.Text = Sum.Text + z.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
