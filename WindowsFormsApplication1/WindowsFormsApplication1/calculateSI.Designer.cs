namespace WindowsFormsApplication1
{
    partial class calculateSI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txt_si = new System.Windows.Forms.TextBox();
            this.btn_calSI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(95, 50);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(100, 20);
            this.txt_p.TabIndex = 4;
            // 
            // txt_r
            // 
            this.txt_r.Location = new System.Drawing.Point(95, 89);
            this.txt_r.Name = "txt_r";
            this.txt_r.Size = new System.Drawing.Size(100, 20);
            this.txt_r.TabIndex = 5;
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(95, 124);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 20);
            this.txt_n.TabIndex = 6;
            // 
            // txt_si
            // 
            this.txt_si.Enabled = false;
            this.txt_si.Location = new System.Drawing.Point(95, 164);
            this.txt_si.Name = "txt_si";
            this.txt_si.Size = new System.Drawing.Size(100, 20);
            this.txt_si.TabIndex = 7;
            // 
            // btn_calSI
            // 
            this.btn_calSI.Location = new System.Drawing.Point(120, 212);
            this.btn_calSI.Name = "btn_calSI";
            this.btn_calSI.Size = new System.Drawing.Size(75, 23);
            this.btn_calSI.TabIndex = 8;
            this.btn_calSI.Text = "CalculateSI";
            this.btn_calSI.UseVisualStyleBackColor = true;
            this.btn_calSI.Click += new System.EventHandler(this.btn_calSI_Click);
            // 
            // calculateSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_calSI);
            this.Controls.Add(this.txt_si);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.txt_r);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "calculateSI";
            this.Text = "calculateSI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.TextBox txt_r;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.TextBox txt_si;
        private System.Windows.Forms.Button btn_calSI;
    }
}