namespace WindowsFormsApplication1
{
    partial class checkboxDemo_2
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
            this.chk_ind = new System.Windows.Forms.CheckBox();
            this.chk_eng = new System.Windows.Forms.CheckBox();
            this.chk_aus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_select = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_ind
            // 
            this.chk_ind.AutoSize = true;
            this.chk_ind.Location = new System.Drawing.Point(13, 36);
            this.chk_ind.Name = "chk_ind";
            this.chk_ind.Size = new System.Drawing.Size(41, 17);
            this.chk_ind.TabIndex = 0;
            this.chk_ind.Text = "Ind";
            this.chk_ind.UseVisualStyleBackColor = true;
            this.chk_ind.CheckedChanged += new System.EventHandler(this.chk_ind_CheckedChanged);
            // 
            // chk_eng
            // 
            this.chk_eng.AutoSize = true;
            this.chk_eng.Location = new System.Drawing.Point(99, 36);
            this.chk_eng.Name = "chk_eng";
            this.chk_eng.Size = new System.Drawing.Size(45, 17);
            this.chk_eng.TabIndex = 1;
            this.chk_eng.Text = "Eng";
            this.chk_eng.UseVisualStyleBackColor = true;
            this.chk_eng.CheckedChanged += new System.EventHandler(this.chk_eng_CheckedChanged);
            // 
            // chk_aus
            // 
            this.chk_aus.AutoSize = true;
            this.chk_aus.Location = new System.Drawing.Point(192, 36);
            this.chk_aus.Name = "chk_aus";
            this.chk_aus.Size = new System.Drawing.Size(44, 17);
            this.chk_aus.TabIndex = 2;
            this.chk_aus.Text = "Aus";
            this.chk_aus.UseVisualStyleBackColor = true;
            this.chk_aus.CheckedChanged += new System.EventHandler(this.chk_aus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "U have selected :- ";
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Location = new System.Drawing.Point(18, 160);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(0, 13);
            this.lbl_select.TabIndex = 4;
            // 
            // checkboxDemo_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_aus);
            this.Controls.Add(this.chk_eng);
            this.Controls.Add(this.chk_ind);
            this.Name = "checkboxDemo_2";
            this.Text = "checkboxDemo_2";
            this.Load += new System.EventHandler(this.checkboxDemo_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_ind;
        private System.Windows.Forms.CheckBox chk_eng;
        private System.Windows.Forms.CheckBox chk_aus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_select;
    }
}