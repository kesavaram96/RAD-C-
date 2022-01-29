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

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.database1DataSet1.Table);
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(database1DataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableBindingSource.MovePrevious();
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = tableBindingSource.Count;
            label1.Text = "You Have Entered "+count.ToString()+" Students Details";

            if(count<2)
            {
                button4.Visible = false;
                button5.Visible = false;
            }
            else
            {
                button4.Visible = true;
                button5.Visible = true;
            }
        }

        private void q1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Q1(this.database1DataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void q1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Q1(this.database1DataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        /*
        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Search(this.database1DataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        */
        private void r1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tableTableAdapter.r1(this.database1DataSet.Table, ((int)(System.Convert.ChangeType(studentIdToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void q3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter1.q3(this.database1DataSet1.Table, ((int)(System.Convert.ChangeType(studentIdToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
