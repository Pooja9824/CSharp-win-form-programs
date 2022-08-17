namespace WindowsFormsApplication1
{
    partial class comboboxDemo2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_one = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_one = new System.Windows.Forms.ComboBox();
            this.btn_rem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // txt_one
            // 
            this.txt_one.Location = new System.Drawing.Point(113, 29);
            this.txt_one.Name = "txt_one";
            this.txt_one.Size = new System.Drawing.Size(100, 20);
            this.txt_one.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(103, 96);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmb_one
            // 
            this.cmb_one.FormattingEnabled = true;
            this.cmb_one.Location = new System.Drawing.Point(37, 174);
            this.cmb_one.Name = "cmb_one";
            this.cmb_one.Size = new System.Drawing.Size(121, 21);
            this.cmb_one.TabIndex = 3;
            this.cmb_one.SelectedIndexChanged += new System.EventHandler(this.cmb_one_SelectedIndexChanged);
            // 
            // btn_rem
            // 
            this.btn_rem.Location = new System.Drawing.Point(164, 174);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(75, 23);
            this.btn_rem.TabIndex = 4;
            this.btn_rem.Text = "Remove";
            this.btn_rem.UseVisualStyleBackColor = true;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // comboboxDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.cmb_one);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_one);
            this.Controls.Add(this.label1);
            this.Name = "comboboxDemo2";
            this.Text = "comboboxDemo2";
            this.Load += new System.EventHandler(this.comboboxDemo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_one;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_one;
        private System.Windows.Forms.Button btn_rem;
    }
}