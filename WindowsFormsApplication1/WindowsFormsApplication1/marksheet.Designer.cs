namespace WindowsFormsApplication1
{
    partial class marksheet
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rno = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_java = new System.Windows.Forms.TextBox();
            this.txt_obt = new System.Windows.Forms.TextBox();
            this.txt_cs = new System.Windows.Forms.TextBox();
            this.txt_per = new System.Windows.Forms.TextBox();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.txt_os = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RollNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Java";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Obtained";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "c#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Per";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Net";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Grade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "OS";
            // 
            // txt_rno
            // 
            this.txt_rno.Location = new System.Drawing.Point(88, 37);
            this.txt_rno.Name = "txt_rno";
            this.txt_rno.Size = new System.Drawing.Size(100, 20);
            this.txt_rno.TabIndex = 9;
            this.txt_rno.TextChanged += new System.EventHandler(this.txt_rno_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(304, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 10;
            // 
            // txt_java
            // 
            this.txt_java.Location = new System.Drawing.Point(88, 85);
            this.txt_java.Name = "txt_java";
            this.txt_java.Size = new System.Drawing.Size(100, 20);
            this.txt_java.TabIndex = 11;
            // 
            // txt_obt
            // 
            this.txt_obt.Enabled = false;
            this.txt_obt.Location = new System.Drawing.Point(304, 88);
            this.txt_obt.Name = "txt_obt";
            this.txt_obt.Size = new System.Drawing.Size(100, 20);
            this.txt_obt.TabIndex = 12;
            // 
            // txt_cs
            // 
            this.txt_cs.Location = new System.Drawing.Point(88, 130);
            this.txt_cs.Name = "txt_cs";
            this.txt_cs.Size = new System.Drawing.Size(100, 20);
            this.txt_cs.TabIndex = 13;
            // 
            // txt_per
            // 
            this.txt_per.Enabled = false;
            this.txt_per.Location = new System.Drawing.Point(304, 132);
            this.txt_per.Name = "txt_per";
            this.txt_per.Size = new System.Drawing.Size(100, 20);
            this.txt_per.TabIndex = 14;
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(88, 178);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(100, 20);
            this.txt_net.TabIndex = 15;
            // 
            // txt_grade
            // 
            this.txt_grade.Enabled = false;
            this.txt_grade.Location = new System.Drawing.Point(304, 181);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(100, 20);
            this.txt_grade.TabIndex = 16;
            // 
            // txt_os
            // 
            this.txt_os.Location = new System.Drawing.Point(88, 220);
            this.txt_os.Name = "txt_os";
            this.txt_os.Size = new System.Drawing.Size(100, 20);
            this.txt_os.TabIndex = 17;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(176, 272);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 18;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.TextChanged += new System.EventHandler(this.btn_cal_TextChanged);
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // marksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 307);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_os);
            this.Controls.Add(this.txt_grade);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.txt_per);
            this.Controls.Add(this.txt_cs);
            this.Controls.Add(this.txt_obt);
            this.Controls.Add(this.txt_java);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_rno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "marksheet";
            this.Text = "marksheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_rno;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_java;
        private System.Windows.Forms.TextBox txt_obt;
        private System.Windows.Forms.TextBox txt_cs;
        private System.Windows.Forms.TextBox txt_per;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.TextBox txt_os;
        private System.Windows.Forms.Button btn_cal;
    }
}