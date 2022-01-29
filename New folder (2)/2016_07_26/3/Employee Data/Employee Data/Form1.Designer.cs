namespace Employee_Data
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emp_IDLabel;
            System.Windows.Forms.Label emp_NameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label maleLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label javaLabel;
            System.Windows.Forms.Label c_Label;
            System.Windows.Forms.Label c__Label;
            System.Windows.Forms.Label satisfactionLabel;
            System.Windows.Forms.Label profile_PictureLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new Employee_Data.EmployeeDataSet();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.emp_NameTextBox = new System.Windows.Forms.TextBox();
            this.emp_IDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.satisfactionTrackBar = new System.Windows.Forms.TrackBar();
            this.c__CheckBox = new System.Windows.Forms.CheckBox();
            this.c_CheckBox = new System.Windows.Forms.CheckBox();
            this.javaCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableTableAdapter = new Employee_Data.EmployeeDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Employee_Data.EmployeeDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.profile_PicturePictureBox = new System.Windows.Forms.PictureBox();
            emp_IDLabel = new System.Windows.Forms.Label();
            emp_NameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            maleLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            javaLabel = new System.Windows.Forms.Label();
            c_Label = new System.Windows.Forms.Label();
            c__Label = new System.Windows.Forms.Label();
            satisfactionLabel = new System.Windows.Forms.Label();
            profile_PictureLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisfactionTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_PicturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_IDLabel
            // 
            emp_IDLabel.AutoSize = true;
            emp_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_IDLabel.Location = new System.Drawing.Point(6, 39);
            emp_IDLabel.Name = "emp_IDLabel";
            emp_IDLabel.Size = new System.Drawing.Size(61, 18);
            emp_IDLabel.TabIndex = 0;
            emp_IDLabel.Text = "Emp ID:";
            // 
            // emp_NameLabel
            // 
            emp_NameLabel.AutoSize = true;
            emp_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_NameLabel.Location = new System.Drawing.Point(6, 71);
            emp_NameLabel.Name = "emp_NameLabel";
            emp_NameLabel.Size = new System.Drawing.Size(87, 18);
            emp_NameLabel.TabIndex = 2;
            emp_NameLabel.Text = "Emp Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(6, 105);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(37, 18);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(6, 135);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 18);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(6, 167);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(66, 18);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // maleLabel
            // 
            maleLabel.AutoSize = true;
            maleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maleLabel.Location = new System.Drawing.Point(10, 290);
            maleLabel.Name = "maleLabel";
            maleLabel.Size = new System.Drawing.Size(61, 18);
            maleLabel.TabIndex = 10;
            maleLabel.Text = "Gender:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(7, 32);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 0;
            departmentLabel.Text = "Department:";
            // 
            // javaLabel
            // 
            javaLabel.AutoSize = true;
            javaLabel.Location = new System.Drawing.Point(7, 69);
            javaLabel.Name = "javaLabel";
            javaLabel.Size = new System.Drawing.Size(33, 13);
            javaLabel.TabIndex = 2;
            javaLabel.Text = "Java:";
            // 
            // c_Label
            // 
            c_Label.AutoSize = true;
            c_Label.Location = new System.Drawing.Point(24, 109);
            c_Label.Name = "c_Label";
            c_Label.Size = new System.Drawing.Size(24, 13);
            c_Label.TabIndex = 4;
            c_Label.Text = "C#:";
            // 
            // c__Label
            // 
            c__Label.AutoSize = true;
            c__Label.Location = new System.Drawing.Point(25, 155);
            c__Label.Name = "c__Label";
            c__Label.Size = new System.Drawing.Size(29, 13);
            c__Label.TabIndex = 6;
            c__Label.Text = "C++:";
            // 
            // satisfactionLabel
            // 
            satisfactionLabel.AutoSize = true;
            satisfactionLabel.Location = new System.Drawing.Point(38, 194);
            satisfactionLabel.Name = "satisfactionLabel";
            satisfactionLabel.Size = new System.Drawing.Size(65, 13);
            satisfactionLabel.TabIndex = 8;
            satisfactionLabel.Text = "Satisfaction:";
            // 
            // profile_PictureLabel
            // 
            profile_PictureLabel.AutoSize = true;
            profile_PictureLabel.Location = new System.Drawing.Point(564, 69);
            profile_PictureLabel.Name = "profile_PictureLabel";
            profile_PictureLabel.Size = new System.Drawing.Size(75, 13);
            profile_PictureLabel.TabIndex = 9;
            profile_PictureLabel.Text = "Profile Picture:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Controls.Add(maleLabel);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressRichTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(ageLabel);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(emp_NameLabel);
            this.groupBox1.Controls.Add(this.emp_NameTextBox);
            this.groupBox1.Controls.Add(emp_IDLabel);
            this.groupBox1.Controls.Add(this.emp_IDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Details";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Female", true));
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.Location = new System.Drawing.Point(176, 287);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(86, 24);
            this.femaleRadioButton.TabIndex = 13;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "Male", true));
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.Location = new System.Drawing.Point(94, 287);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(104, 24);
            this.maleRadioButton.TabIndex = 11;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Address", true));
            this.addressRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressRichTextBox.Location = new System.Drawing.Point(94, 163);
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(168, 96);
            this.addressRichTextBox.TabIndex = 9;
            this.addressRichTextBox.Text = "";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(94, 131);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(168, 26);
            this.phoneTextBox.TabIndex = 7;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Age", true));
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.Location = new System.Drawing.Point(94, 99);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(168, 26);
            this.ageTextBox.TabIndex = 5;
            // 
            // emp_NameTextBox
            // 
            this.emp_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Emp_Name", true));
            this.emp_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_NameTextBox.Location = new System.Drawing.Point(94, 67);
            this.emp_NameTextBox.Name = "emp_NameTextBox";
            this.emp_NameTextBox.Size = new System.Drawing.Size(168, 26);
            this.emp_NameTextBox.TabIndex = 3;
            // 
            // emp_IDTextBox
            // 
            this.emp_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Emp_ID", true));
            this.emp_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_IDTextBox.Location = new System.Drawing.Point(94, 35);
            this.emp_IDTextBox.Name = "emp_IDTextBox";
            this.emp_IDTextBox.Size = new System.Drawing.Size(168, 26);
            this.emp_IDTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(satisfactionLabel);
            this.groupBox2.Controls.Add(this.satisfactionTrackBar);
            this.groupBox2.Controls.Add(c__Label);
            this.groupBox2.Controls.Add(this.c__CheckBox);
            this.groupBox2.Controls.Add(c_Label);
            this.groupBox2.Controls.Add(this.c_CheckBox);
            this.groupBox2.Controls.Add(javaLabel);
            this.groupBox2.Controls.Add(this.javaCheckBox);
            this.groupBox2.Controls.Add(departmentLabel);
            this.groupBox2.Controls.Add(this.departmentComboBox);
            this.groupBox2.Location = new System.Drawing.Point(315, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 370);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Details";
            // 
            // satisfactionTrackBar
            // 
            this.satisfactionTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "Satisfaction", true));
            this.satisfactionTrackBar.Location = new System.Drawing.Point(109, 194);
            this.satisfactionTrackBar.Name = "satisfactionTrackBar";
            this.satisfactionTrackBar.Size = new System.Drawing.Size(104, 45);
            this.satisfactionTrackBar.TabIndex = 9;
            // 
            // c__CheckBox
            // 
            this.c__CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "C++", true));
            this.c__CheckBox.Location = new System.Drawing.Point(60, 150);
            this.c__CheckBox.Name = "c__CheckBox";
            this.c__CheckBox.Size = new System.Drawing.Size(104, 24);
            this.c__CheckBox.TabIndex = 7;
            this.c__CheckBox.Text = "checkBox1";
            this.c__CheckBox.UseVisualStyleBackColor = true;
            // 
            // c_CheckBox
            // 
            this.c_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "C#", true));
            this.c_CheckBox.Location = new System.Drawing.Point(54, 104);
            this.c_CheckBox.Name = "c_CheckBox";
            this.c_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.c_CheckBox.TabIndex = 5;
            this.c_CheckBox.Text = "checkBox1";
            this.c_CheckBox.UseVisualStyleBackColor = true;
            // 
            // javaCheckBox
            // 
            this.javaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "Java", true));
            this.javaCheckBox.Location = new System.Drawing.Point(46, 64);
            this.javaCheckBox.Name = "javaCheckBox";
            this.javaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.javaCheckBox.TabIndex = 3;
            this.javaCheckBox.Text = "checkBox1";
            this.javaCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Department", true));
            this.departmentComboBox.DataSource = this.tableBindingSource;
            this.departmentComboBox.DisplayMember = "Department";
            this.departmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(78, 29);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 28);
            this.departmentComboBox.TabIndex = 1;
            this.departmentComboBox.ValueMember = "Department";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Employee_Data.EmployeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(696, 25);
            this.tableBindingNavigator.TabIndex = 8;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // profile_PicturePictureBox
            // 
            this.profile_PicturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "Profile Picture", true));
            this.profile_PicturePictureBox.Location = new System.Drawing.Point(564, 85);
            this.profile_PicturePictureBox.Name = "profile_PicturePictureBox";
            this.profile_PicturePictureBox.Size = new System.Drawing.Size(100, 90);
            this.profile_PicturePictureBox.TabIndex = 10;
            this.profile_PicturePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 453);
            this.Controls.Add(profile_PictureLabel);
            this.Controls.Add(this.profile_PicturePictureBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisfactionTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_PicturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private EmployeeDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private EmployeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RichTextBox addressRichTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox emp_NameTextBox;
        private System.Windows.Forms.TextBox emp_IDTextBox;
        private System.Windows.Forms.TrackBar satisfactionTrackBar;
        private System.Windows.Forms.CheckBox c__CheckBox;
        private System.Windows.Forms.CheckBox c_CheckBox;
        private System.Windows.Forms.CheckBox javaCheckBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.PictureBox profile_PicturePictureBox;
    }
}

