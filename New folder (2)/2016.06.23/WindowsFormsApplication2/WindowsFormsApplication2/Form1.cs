﻿using System;
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
                Form2 Frm2 = new Form2();
                Frm2.FormClosed += new FormClosedEventHandler(Splach_scr_close);
                this.Hide();
                Frm2.Show();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       /* private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }*/

        private void Splach_scr_close(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
