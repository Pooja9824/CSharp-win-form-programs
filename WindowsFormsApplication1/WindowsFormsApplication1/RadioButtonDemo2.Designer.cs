namespace WindowsFormsApplication1
{
    partial class RadioButtonDemo2
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
            this.btn_get = new System.Windows.Forms.Button();
            this.lbl_first = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdo_red
            // 
            this.rdo_red.AutoSize = true;
            this.rdo_red.Location = new System.Drawing.Point(49, 37);
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
            this.rdo_yellow.Location = new System.Drawing.Point(49, 79);
            this.rdo_yellow.Name = "rdo_yellow";
            this.rdo_yellow.Size = new System.Drawing.Size(56, 17);
            this.rdo_yellow.TabIndex = 1;
            this.rdo_yellow.TabStop = true;
            this.rdo_yellow.Text = "Yellow";
            this.rdo_yellow.UseVisualStyleBackColor = true;
            // 
            // rdo_blue
            // 
            this.rdo_blue.AutoSize = true;
            this.rdo_blue.Location = new System.Drawing.Point(49, 122);
            this.rdo_blue.Name = "rdo_blue";
            this.rdo_blue.Size = new System.Drawing.Size(46, 17);
            this.rdo_blue.TabIndex = 2;
            this.rdo_blue.TabStop = true;
            this.rdo_blue.Text = "Blue";
            this.rdo_blue.UseVisualStyleBackColor = true;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(49, 172);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 3;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lbl_first
            // 
            this.lbl_first.AutoSize = true;
            this.lbl_first.Location = new System.Drawing.Point(49, 220);
            this.lbl_first.Name = "lbl_first";
            this.lbl_first.Size = new System.Drawing.Size(0, 13);
            this.lbl_first.TabIndex = 4;
            // 
            // RadioButtonDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_first);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.rdo_blue);
            this.Controls.Add(this.rdo_yellow);
            this.Controls.Add(this.rdo_red);
            this.Name = "RadioButtonDemo2";
            this.Text = "RadioButtonDemo2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_red;
        private System.Windows.Forms.RadioButton rdo_yellow;
        private System.Windows.Forms.RadioButton rdo_blue;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label lbl_first;
    }
}