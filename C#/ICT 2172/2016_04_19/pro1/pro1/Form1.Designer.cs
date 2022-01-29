namespace pro1
{
    partial class cal
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.SUB = new System.Windows.Forms.Button();
            this.tbr = new System.Windows.Forms.TextBox();
            this.MUL = new System.Windows.Forms.Button();
            this.DIV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(201, 51);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(201, 92);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number2";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(48, 217);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 4;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.add_Click);
            // 
            // SUB
            // 
            this.SUB.Location = new System.Drawing.Point(172, 217);
            this.SUB.Name = "SUB";
            this.SUB.Size = new System.Drawing.Size(75, 23);
            this.SUB.TabIndex = 5;
            this.SUB.Text = "SUB";
            this.SUB.UseVisualStyleBackColor = true;
            this.SUB.Click += new System.EventHandler(this.SUB_Click);
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(201, 156);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(100, 20);
            this.tbr.TabIndex = 6;
            // 
            // MUL
            // 
            this.MUL.Location = new System.Drawing.Point(48, 254);
            this.MUL.Name = "MUL";
            this.MUL.Size = new System.Drawing.Size(75, 23);
            this.MUL.TabIndex = 7;
            this.MUL.Text = "MUL";
            this.MUL.UseVisualStyleBackColor = true;
            this.MUL.Click += new System.EventHandler(this.MUL_Click);
            // 
            // DIV
            // 
            this.DIV.Location = new System.Drawing.Point(172, 254);
            this.DIV.Name = "DIV";
            this.DIV.Size = new System.Drawing.Size(75, 23);
            this.DIV.TabIndex = 8;
            this.DIV.Text = "DIV";
            this.DIV.UseVisualStyleBackColor = true;
            this.DIV.Click += new System.EventHandler(this.DIV_Click);
            // 
            // cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(352, 301);
            this.Controls.Add(this.DIV);
            this.Controls.Add(this.MUL);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.SUB);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "cal";
            this.Text = "cal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button SUB;
        private System.Windows.Forms.TextBox tbr;
        private System.Windows.Forms.Button MUL;
        private System.Windows.Forms.Button DIV;
    }
}

