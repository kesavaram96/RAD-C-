using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
           
        }
        int i = 0;
        String[] img_path=Directory.GetFiles("C:/Users/User/Desktop/New folder (2)/2016_07_12/1/WindowsFormsApplication1/WindowsFormsApplication1/bin/image","*.jpg");
        private void button1_Click(object sender, EventArgs e)
        {
            i = (i + img_path.Length-1) % img_path.Length;
            pictureBox1.Image = Image.FromFile(img_path[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = (i + 1) % img_path.Length;
            pictureBox1.Image = Image.FromFile(img_path[i]);
        }
    }
}
