namespace WindowsFormsApplication1
{
    partial class calculateSI2
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txt_si = new System.Windows.Forms.TextBox();
            this.btn_calsi = new System.Windows.Forms.Button();
            this.btn_do = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(42, 44);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(14, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SI";
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(86, 41);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(100, 20);
            this.txt_p.TabIndex = 0;
            // 
            // txt_r
            // 
            this.txt_r.Location = new System.Drawing.Point(86, 74);
            this.txt_r.Name = "txt_r";
            this.txt_r.ReadOnly = true;
            this.txt_r.Size = new System.Drawing.Size(100, 20);
            this.txt_r.TabIndex = 5;
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(86, 111);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 20);
            this.txt_n.TabIndex = 2;
            // 
            // txt_si
            // 
            this.txt_si.Enabled = false;
            this.txt_si.Location = new System.Drawing.Point(86, 149);
            this.txt_si.Name = "txt_si";
            this.txt_si.Size = new System.Drawing.Size(100, 20);
            this.txt_si.TabIndex = 3;
            // 
            // btn_calsi
            // 
            this.btn_calsi.Location = new System.Drawing.Point(111, 202);
            this.btn_calsi.Name = "btn_calsi";
            this.btn_calsi.Size = new System.Drawing.Size(75, 23);
            this.btn_calsi.TabIndex = 4;
            this.btn_calsi.Text = "CalculateSI";
            this.btn_calsi.UseVisualStyleBackColor = true;
            this.btn_calsi.Click += new System.EventHandler(this.btn_calsi_Click);
            // 
            // btn_do
            // 
            this.btn_do.Location = new System.Drawing.Point(203, 74);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(43, 23);
            this.btn_do.TabIndex = 1;
            this.btn_do.Text = "Do";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // calculateSI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.btn_calsi);
            this.Controls.Add(this.txt_si);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.txt_r);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Name = "calculateSI2";
            this.Text = "calculateSI2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.TextBox txt_r;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.TextBox txt_si;
        private System.Windows.Forms.Button btn_calsi;
        private System.Windows.Forms.Button btn_do;
    }
}