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
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);
            timer1.Start();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.AddNew();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.RemoveCurrent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(database1DataSet);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            tableBindingSource.MoveNext();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            tableBindingSource.MovePrevious();
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = tableBindingSource.Count;
            labelstatus.Text = "You have entered " + count.ToString() + " Students details";

            if(count<2)
            {
                buttonNext.Visible = false;
                buttonPrevious.Visible = false;
            }
            else
            {
                buttonNext.Visible = true;
                buttonPrevious.Visible = true;
            }
        }
    }
}
