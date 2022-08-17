namespace WindowsFormsApplication1
{
    partial class Bill
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_one = new System.Windows.Forms.Label();
            this.lbl_two = new System.Windows.Forms.Label();
            this.lbl_three = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_four = new System.Windows.Forms.Label();
            this.chk_parcel = new System.Windows.Forms.CheckBox();
            this.btn_bill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Plaza";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(65, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Italian              150";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(65, 122);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Regular           130";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(65, 154);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(114, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Plaza Special  180";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(196, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(196, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(196, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "QTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total";
            // 
            // lbl_one
            // 
            this.lbl_one.AutoSize = true;
            this.lbl_one.Location = new System.Drawing.Point(379, 90);
            this.lbl_one.Name = "lbl_one";
            this.lbl_one.Size = new System.Drawing.Size(0, 13);
            this.lbl_one.TabIndex = 9;
            // 
            // lbl_two
            // 
            this.lbl_two.AutoSize = true;
            this.lbl_two.Location = new System.Drawing.Point(379, 122);
            this.lbl_two.Name = "lbl_two";
            this.lbl_two.Size = new System.Drawing.Size(0, 13);
            this.lbl_two.TabIndex = 10;
            // 
            // lbl_three
            // 
            this.lbl_three.AutoSize = true;
            this.lbl_three.Location = new System.Drawing.Point(379, 157);
            this.lbl_three.Name = "lbl_three";
            this.lbl_three.Size = new System.Drawing.Size(0, 13);
            this.lbl_three.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Payment";
            // 
            // lbl_four
            // 
            this.lbl_four.AutoSize = true;
            this.lbl_four.Location = new System.Drawing.Point(350, 203);
            this.lbl_four.Name = "lbl_four";
            this.lbl_four.Size = new System.Drawing.Size(0, 13);
            this.lbl_four.TabIndex = 13;
            // 
            // chk_parcel
            // 
            this.chk_parcel.AutoSize = true;
            this.chk_parcel.Location = new System.Drawing.Point(65, 258);
            this.chk_parcel.Name = "chk_parcel";
            this.chk_parcel.Size = new System.Drawing.Size(92, 17);
            this.chk_parcel.TabIndex = 14;
            this.chk_parcel.Text = "Parcel     + 10";
            this.chk_parcel.UseVisualStyleBackColor = true;
            this.chk_parcel.CheckedChanged += new System.EventHandler(this.chk_parcel_CheckedChanged);
            // 
            // btn_bill
            // 
            this.btn_bill.Location = new System.Drawing.Point(353, 252);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(75, 23);
            this.btn_bill.TabIndex = 15;
            this.btn_bill.Text = "CalculateBill";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 318);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.chk_parcel);
            this.Controls.Add(this.lbl_four);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_three);
            this.Controls.Add(this.lbl_two);
            this.Controls.Add(this.lbl_one);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_one;
        private System.Windows.Forms.Label lbl_two;
        private System.Windows.Forms.Label lbl_three;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_four;
        private System.Windows.Forms.CheckBox chk_parcel;
        private System.Windows.Forms.Button btn_bill;
    }
}