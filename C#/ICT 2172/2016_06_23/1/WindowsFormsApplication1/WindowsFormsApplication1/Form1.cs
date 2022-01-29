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

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value==100)
            {
                timer1.Stop();
                Form2 fm2 = new Form2();
                fm2.FormClosed += new FormClosedEventHandler(Splach_scr_close);
                this.Hide();
                fm2.Show();
            }
        }

        private void Splach_scr_close(object sender, FormClosedEventArgs e)
        {//we creat a method to close form1
            this.Close();
        }
    }
}
