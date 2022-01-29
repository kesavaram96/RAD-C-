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

namespace Media_Player
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                file = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fg = new QuartzTypeLib.FilgraphManager();
            fg.RenderFile(file);
            try
            {
                window = (IVideoWindow)fg;
                window.Owner = (int)this.panel1.Handle;
                window.WindowStyle = 0x40000000 | 0x20000000;
                this.window.SetWindowPosition(panel1.ClientRectangle.Left, 
                                                panel1.ClientRectangle.Top, 
                                                panel1.ClientRectangle.Width,
                                                panel1.ClientRectangle.Right);
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
