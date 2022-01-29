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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // pictureBox1.Image=Image.FromFile("../image/Penguins.jpg");
        }

        String[] img_path = Directory.GetFiles("../image/", "*.jpg");
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            i = ((i + 1) % img_path.Length);
            pictureBox1.Image = Image.FromFile(img_path[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = ((i+img_path.Length - 1) % img_path.Length);
            pictureBox1.Image = Image.FromFile(img_path[i]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
