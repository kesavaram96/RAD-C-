namespace Error_Help_Provider
{
    partial class Form2
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
            this.il = new System.Windows.Forms.Label();
            this.al = new System.Windows.Forms.Label();
            this.el = new System.Windows.Forms.Label();
            this.nt = new System.Windows.Forms.TextBox();
            this.it = new System.Windows.Forms.TextBox();
            this.at = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // nl
            // 
            this.nl.AutoSize = true;
            this.nl.Location = new System.Drawing.Point(33, 29);
            this.nl.Name = "nl";
            this.nl.Size = new System.Drawing.Size(41, 13);
            this.nl.TabIndex = 0;
            this.nl.Text = "Name :";
            // 
            // il
            // 
            this.il.AutoSize = true;
            this.il.Location = new System.Drawing.Point(33, 62);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(56, 13);
            this.il.TabIndex = 1;
            this.il.Text = "Index No :";
            // 
            // al
            // 
            this.al.AutoSize = true;
            this.al.Location = new System.Drawing.Point(33, 100);
            this.al.Name = "al";
            this.al.Size = new System.Drawing.Size(32, 13);
            this.al.TabIndex = 2;
            this.al.Text = "Age :";
            // 
            // el
            // 
            this.el.AutoSize = true;
            this.el.Location = new System.Drawing.Point(33, 133);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(65, 13);
            this.el.TabIndex = 3;
            this.el.Text = "Exam Date :";
            // 
            // nt
            // 
            this.nt.Location = new System.Drawing.Point(114, 29);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(200, 20);
            this.nt.TabIndex = 4;
            // 
            // it
            // 
            this.it.Location = new System.Drawing.Point(114, 62);
            this.it.Name = "it";
            this.it.Size = new System.Drawing.Size(200, 20);
            this.it.TabIndex = 5;
            // 
            // at
            // 
            this.at.Location = new System.Drawing.Point(114, 100);
            this.at.Name = "at";
            this.at.Size = new System.Drawing.Size(200, 20);
            this.at.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(114, 133);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.at);
            this.Controls.Add(this.it);
            this.Controls.Add(this.nt);
            this.Controls.Add(this.el);
            this.Controls.Add(this.al);
            this.Controls.Add(this.il);
            this.Controls.Add(this.nl);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nl;
        private System.Windows.Forms.Label il;
        private System.Windows.Forms.Label al;
        private System.Windows.Forms.Label el;
        private System.Windows.Forms.TextBox nt;
        private System.Windows.Forms.TextBox it;
        private System.Windows.Forms.TextBox at;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}