namespace Error_Help_Provider
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
            this.nl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sb = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nl
            // 
            this.nl.AutoSize = true;
            this.nl.Location = new System.Drawing.Point(28, 39);
            this.nl.Name = "nl";
            this.nl.Size = new System.Drawing.Size(44, 13);
            this.nl.TabIndex = 0;
            this.nl.Text = "Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // sb
            // 
            this.sb.Location = new System.Drawing.Point(105, 97);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(75, 23);
            this.sb.TabIndex = 2;
            this.sb.Text = "Submit";
            this.sb.UseVisualStyleBackColor = true;
            this.sb.Click += new System.EventHandler(this.sb_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nl);
            this.Name = "Form1";
            this.Text = "Exam entry form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

