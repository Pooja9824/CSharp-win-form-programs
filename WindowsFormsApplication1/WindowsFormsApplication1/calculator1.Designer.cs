namespace WindowsFormsApplication1
{
    partial class calculator1
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
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_oddeven = new System.Windows.Forms.Button();
            this.btn_minmax = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_swap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(128, 44);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 20);
            this.txt_x.TabIndex = 0;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(128, 96);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 20);
            this.txt_y.TabIndex = 1;
            // 
            // txt_ans
            // 
            this.txt_ans.Enabled = false;
            this.txt_ans.Location = new System.Drawing.Point(128, 149);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(196, 20);
            this.txt_ans.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ans";
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(42, 205);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(39, 23);
            this.btn_sum.TabIndex = 6;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(92, 205);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(40, 23);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(138, 205);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(42, 23);
            this.btn_mul.TabIndex = 8;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(186, 205);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(42, 23);
            this.btn_div.TabIndex = 9;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_oddeven
            // 
            this.btn_oddeven.Location = new System.Drawing.Point(42, 256);
            this.btn_oddeven.Name = "btn_oddeven";
            this.btn_oddeven.Size = new System.Drawing.Size(75, 23);
            this.btn_oddeven.TabIndex = 10;
            this.btn_oddeven.Text = "odd_even";
            this.btn_oddeven.UseVisualStyleBackColor = true;
            this.btn_oddeven.Click += new System.EventHandler(this.btn_oddeven_Click);
            // 
            // btn_minmax
            // 
            this.btn_minmax.Location = new System.Drawing.Point(153, 256);
            this.btn_minmax.Name = "btn_minmax";
            this.btn_minmax.Size = new System.Drawing.Size(75, 23);
            this.btn_minmax.TabIndex = 11;
            this.btn_minmax.Text = "Min_Max";
            this.btn_minmax.UseVisualStyleBackColor = true;
            this.btn_minmax.Click += new System.EventHandler(this.btn_minmax_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(56, 285);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 23);
            this.btn_clr.TabIndex = 12;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_swap
            // 
            this.btn_swap.Location = new System.Drawing.Point(137, 285);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(75, 23);
            this.btn_swap.TabIndex = 13;
            this.btn_swap.Text = "Swap";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            // 
            // calculator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 320);
            this.Controls.Add(this.btn_swap);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_minmax);
            this.Controls.Add(this.btn_oddeven);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Name = "calculator1";
            this.Text = "calculator1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_oddeven;
        private System.Windows.Forms.Button btn_minmax;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_swap;
    }
}