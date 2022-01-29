namespace WindowsFormsApplication1
{
    partial class MinusForm
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
            this.Sub = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sub.Location = new System.Drawing.Point(79, 71);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(35, 13);
            this.Sub.TabIndex = 1;
            this.Sub.Text = "Sub : ";
            // 
            // MinusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Sub);
            this.Name = "MinusForm";
            this.Text = "MinusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sub;

    }
}