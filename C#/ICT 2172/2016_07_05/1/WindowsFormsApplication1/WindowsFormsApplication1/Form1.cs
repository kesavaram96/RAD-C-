using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuartzTypeLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string file = "";
        IVideoWindow window = null;
        IMediaControl mc = null;
        FilgraphManager fg = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                file = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fg = new QuartzTypeLib.FilgraphManager();
            try
            {
                window = (IVideoWindow)fg;
                window.Owner = (int)this.panel1.Handle;
                window.WindowStyle = 0x4000000 | 0x2000000;
                this.window.SetWindowPosition(panel1.ClientRectangle.Left, panel1.ClientRectangle.Top, ClientRectangle.Width, ClientRectangle.Right);
            }
            catch(Exception)
            {
                Console.WriteLine("Error........");
            }
            mc = (IMediaControl)fg;
            mc.Run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mc.Stop();
        }
    }
}