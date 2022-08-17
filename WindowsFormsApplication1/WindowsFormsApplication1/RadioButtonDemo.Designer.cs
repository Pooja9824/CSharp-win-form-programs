namespace WindowsFormsApplication1
{
    partial class RadioButtonDemo
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
            this.rdo_red = new System.Windows.Forms.RadioButton();
            this.rdo_yellow = new System.Windows.Forms.RadioButton();
            this.rdo_blue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdo_red
            // 
            this.rdo_red.AutoSize = true;
            this.rdo_red.Location = new System.Drawing.Point(122, 33);
            this.rdo_red.Name = "rdo_red";
            this.rdo_red.Size = new System.Drawing.Size(45, 17);
            this.rdo_red.TabIndex = 0;
            this.rdo_red.TabStop = true;
            this.rdo_red.Text = "Red";
            this.rdo_red.UseVisualStyleBackColor = true;
            this.rdo_red.CheckedChanged += new System.EventHandler(this.rdo_red_CheckedChanged);
            // 
            // rdo_yellow
            // 
            this.rdo_yellow.AutoSize = true;
            this.rdo_yellow.Location = new System.Drawing.Point(122, 69);
            this.rdo_yellow.Name = "rdo_yellow";
            this.rdo_yellow.Size = new System.Drawing.Size(56, 17);
            this.rdo_yellow.TabIndex = 1;
            this.rdo_yellow.TabStop = true;
            this.rdo_yellow.Text = "Yellow";
            this.rdo_yellow.UseVisualStyleBackColor = true;
            this.rdo_yellow.CheckedChanged += new System.EventHandler(this.rdo_yellow_CheckedChanged);
            // 
            // rdo_blue
            // 
            this.rdo_blue.AutoSize = true;
            this.rdo_blue.Location = new System.Drawing.Point(122, 105);
            this.rdo_blue.Name = "rdo_blue";
            this.rdo_blue.Size = new System.Drawing.Size(46, 17);
            this.rdo_blue.TabIndex = 2;
            this.rdo_blue.TabStop = true;
            this.rdo_blue.Text = "Blue";
            this.rdo_blue.UseVisualStyleBackColor = true;
            this.rdo_blue.CheckedChanged += new System.EventHandler(this.rdo_blue_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // RadioButtonDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdo_blue);
            this.Controls.Add(this.rdo_yellow);
            this.Controls.Add(this.rdo_red);
            this.Name = "RadioButtonDemo";
            this.Text = "RadioButtonDemo";
            this.Load += new System.EventHandler(this.RadioButtonDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_red;
        private System.Windows.Forms.RadioButton rdo_yellow;
        private System.Windows.Forms.RadioButton rdo_blue;
        private System.Windows.Forms.Label label1;
    }
}