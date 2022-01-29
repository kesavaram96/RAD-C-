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
    public partial class Form2 : Form
    {
        public Form2(String na,int ag,String ad)
        {
            InitializeComponent();
            Namelabel.Text = Namelabel.Text + na;
            Agelabel.Text = Agelabel.Text + ag.ToString();
            Addresslabel.Text = Addresslabel.Text + ad;
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
