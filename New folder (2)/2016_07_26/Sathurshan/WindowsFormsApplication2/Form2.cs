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

        private void student_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.student_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.student_Table' table. You can move, or remove it, as needed.
            this.student_TableTableAdapter.Fill(this.database1DataSet1.student_Table);
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.student_TableBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.student_TableBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.student_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(database1DataSet1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            student_TableBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            student_TableBindingSource.MovePrevious();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = student_TableBindingSource.Count;
            label1.Text = "you hav entered "+ count.ToString() +" students details";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ageLabel_Click(object sender, EventArgs e)
        {

        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dep_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void dep_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void queryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.student_TableTableAdapter.Query(this.database1DataSet1.student_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //textBox1.Text
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.student_TableTableAdapter.Search(this.database1DataSet1.student_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.student_TableTableAdapter.Search1(this.database1DataSet1.student_Table, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void highToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.student_TableTableAdapter.high(this.database1DataSet1.student_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void highToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
