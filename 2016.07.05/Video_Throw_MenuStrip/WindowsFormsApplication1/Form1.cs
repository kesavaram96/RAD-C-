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
        string file="";
        IVideoWindow window=null;
        IMediaControl mc=null;
        FilgraphManager fg=null;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                file = openFileDialog1.FileName;
            }
        }

        
        private void Play_Click(object sender, EventArgs e)
        {
            fg = new QuartzTypeLib.FilgraphManager();
            fg.RenderFile(file);
            try
            {
                window = (IVideoWindow)fg;
                window.Owner = (int)this.panel1.Handle;
                window.WindowStyle = 0*400000000 | 0*2000000000;
               // window.Height = 720;
               // window.Width = 1080;
                this.window.SetWindowPosition(panel1.ClientRectangle.Left, panel1.ClientRectangle.Top,panel1.ClientRectangle.Width,panel1.ClientRectangle.Right);
            }
            catch(Exception)
            {
                Console.WriteLine(" Error ....... ");
            }
            mc = (IMediaControl)fg;
            mc.Run();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            mc.Stop();
        }
    }
}
