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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        Form3 F3;
        private void button1_Click(object sender, EventArgs e)
        {
            F3 = new Form3();
            F3.FormClosed += new FormClosedEventHandler(Splach_scr_close);
            this.Hide();
            F3.Show();
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Splach_scr_close(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
