namespace WindowsFormsApplication2
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
            this.ob = new System.Windows.Forms.Button();
            this.hb = new System.Windows.Forms.Button();
            this.pcb = new System.Windows.Forms.CheckBox();
            this.scb = new System.Windows.Forms.CheckBox();
            this.dcb = new System.Windows.Forms.CheckBox();
            this.secb = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frb = new System.Windows.Forms.RadioButton();
            this.mrb = new System.Windows.Forms.RadioButton();
            this.ntb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.atb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.srb = new System.Windows.Forms.RadioButton();
            this.mdrb = new System.Windows.Forms.RadioButton();
            this.artb = new System.Windows.Forms.RichTextBox();
            this.srtb = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ob
            // 
            this.ob.BackColor = System.Drawing.Color.SteelBlue;
            this.ob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ob.Location = new System.Drawing.Point(526, 22);
            this.ob.Name = "ob";
            this.ob.Size = new System.Drawing.Size(58, 28);
            this.ob.TabIndex = 0;
            this.ob.Text = "Ok";
            this.ob.UseVisualStyleBackColor = false;
            this.ob.Click += new System.EventHandler(this.ob_Click);
            // 
            // hb
            // 
            this.hb.BackColor = System.Drawing.Color.SteelBlue;
            this.hb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hb.Location = new System.Drawing.Point(526, 71);
            this.hb.Name = "hb";
            this.hb.Size = new System.Drawing.Size(58, 28);
            this.hb.TabIndex = 1;
            this.hb.Text = "Help";
            this.hb.UseVisualStyleBackColor = false;
            // 
            // pcb
            // 
            this.pcb.AutoSize = true;
            this.pcb.Location = new System.Drawing.Point(69, 177);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(82, 17);
            this.pcb.TabIndex = 2;
            this.pcb.Text = "Programmer";
            this.pcb.UseVisualStyleBackColor = true;
            // 
            // scb
            // 
            this.scb.AutoSize = true;
            this.scb.Location = new System.Drawing.Point(214, 177);
            this.scb.Name = "scb";
            this.scb.Size = new System.Drawing.Size(63, 17);
            this.scb.TabIndex = 3;
            this.scb.Text = "Student";
            this.scb.UseVisualStyleBackColor = true;
            // 
            // dcb
            // 
            this.dcb.AutoSize = true;
            this.dcb.Location = new System.Drawing.Point(342, 177);
            this.dcb.Name = "dcb";
            this.dcb.Size = new System.Drawing.Size(75, 17);
            this.dcb.TabIndex = 4;
            this.dcb.Text = "Developer";
            this.dcb.UseVisualStyleBackColor = true;
            // 
            // secb
            // 
            this.secb.AutoSize = true;
            this.secb.Location = new System.Drawing.Point(471, 177);
            this.secb.Name = "secb";
            this.secb.Size = new System.Drawing.Size(113, 17);
            this.secb.TabIndex = 5;
            this.secb.Text = "Software Engineer";
            this.secb.UseVisualStyleBackColor = true;
            this.secb.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frb);
            this.groupBox1.Controls.Add(this.mrb);
            this.groupBox1.Location = new System.Drawing.Point(69, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // frb
            // 
            this.frb.AutoSize = true;
            this.frb.Location = new System.Drawing.Point(145, 29);
            this.frb.Name = "frb";
            this.frb.Size = new System.Drawing.Size(59, 17);
            this.frb.TabIndex = 1;
            this.frb.TabStop = true;
            this.frb.Text = "Female";
            this.frb.UseVisualStyleBackColor = true;
            // 
            // mrb
            // 
            this.mrb.AutoSize = true;
            this.mrb.Location = new System.Drawing.Point(28, 29);
            this.mrb.Name = "mrb";
            this.mrb.Size = new System.Drawing.Size(48, 17);
            this.mrb.TabIndex = 0;
            this.mrb.TabStop = true;
            this.mrb.Text = "Male";
            this.mrb.UseVisualStyleBackColor = true;
            // 
            // ntb
            // 
            this.ntb.Location = new System.Drawing.Point(186, 22);
            this.ntb.Name = "ntb";
            this.ntb.Size = new System.Drawing.Size(304, 20);
            this.ntb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Age :";
            // 
            // atb
            // 
            this.atb.Location = new System.Drawing.Point(186, 304);
            this.atb.Name = "atb";
            this.atb.Size = new System.Drawing.Size(136, 20);
            this.atb.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.srb);
            this.groupBox2.Controls.Add(this.mdrb);
            this.groupBox2.Location = new System.Drawing.Point(342, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Civil Status";
            // 
            // srb
            // 
            this.srb.AutoSize = true;
            this.srb.Location = new System.Drawing.Point(148, 29);
            this.srb.Name = "srb";
            this.srb.Size = new System.Drawing.Size(54, 17);
            this.srb.TabIndex = 1;
            this.srb.TabStop = true;
            this.srb.Text = "Single";
            this.srb.UseVisualStyleBackColor = true;
            // 
            // mdrb
            // 
            this.mdrb.AutoSize = true;
            this.mdrb.Location = new System.Drawing.Point(28, 29);
            this.mdrb.Name = "mdrb";
            this.mdrb.Size = new System.Drawing.Size(60, 17);
            this.mdrb.TabIndex = 0;
            this.mdrb.TabStop = true;
            this.mdrb.Text = "Married";
            this.mdrb.UseVisualStyleBackColor = true;
            // 
            // artb
            // 
            this.artb.Location = new System.Drawing.Point(186, 68);
            this.artb.Name = "artb";
            this.artb.Size = new System.Drawing.Size(304, 96);
            this.artb.TabIndex = 12;
            this.artb.Text = "";
            // 
            // srtb
            // 
            this.srtb.Location = new System.Drawing.Point(186, 355);
            this.srtb.Name = "srtb";
            this.srtb.Size = new System.Drawing.Size(304, 96);
            this.srtb.TabIndex = 13;
            this.srtb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(652, 463);
            this.Controls.Add(this.srtb);
            this.Controls.Add(this.artb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.atb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ntb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.secb);
            this.Controls.Add(this.dcb);
            this.Controls.Add(this.scb);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.hb);
            this.Controls.Add(this.ob);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ob;
        private System.Windows.Forms.Button hb;
        private System.Windows.Forms.CheckBox pcb;
        private System.Windows.Forms.CheckBox scb;
        private System.Windows.Forms.CheckBox dcb;
        private System.Windows.Forms.CheckBox secb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton frb;
        private System.Windows.Forms.RadioButton mrb;
        private System.Windows.Forms.TextBox ntb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox atb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton srb;
        private System.Windows.Forms.RadioButton mdrb;
        private System.Windows.Forms.RichTextBox artb;
        private System.Windows.Forms.RichTextBox srtb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

