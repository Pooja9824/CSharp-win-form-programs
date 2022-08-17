namespace WindowsFormsApplication1
{
    partial class checkboxDemo
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
            this.chk_carrom = new System.Windows.Forms.CheckBox();
            this.chk_cricket = new System.Windows.Forms.CheckBox();
            this.chk_hockey = new System.Windows.Forms.CheckBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_carrom
            // 
            this.chk_carrom.AutoSize = true;
            this.chk_carrom.Location = new System.Drawing.Point(73, 49);
            this.chk_carrom.Name = "chk_carrom";
            this.chk_carrom.Size = new System.Drawing.Size(59, 17);
            this.chk_carrom.TabIndex = 0;
            this.chk_carrom.Text = "Carrom";
            this.chk_carrom.UseVisualStyleBackColor = true;
            this.chk_carrom.CheckedChanged += new System.EventHandler(this.chk_carrom_CheckedChanged);
            // 
            // chk_cricket
            // 
            this.chk_cricket.AutoSize = true;
            this.chk_cricket.Location = new System.Drawing.Point(73, 97);
            this.chk_cricket.Name = "chk_cricket";
            this.chk_cricket.Size = new System.Drawing.Size(59, 17);
            this.chk_cricket.TabIndex = 1;
            this.chk_cricket.Text = "Cricket";
            this.chk_cricket.UseVisualStyleBackColor = true;
            this.chk_cricket.CheckedChanged += new System.EventHandler(this.chk_cricket_CheckedChanged);
            // 
            // chk_hockey
            // 
            this.chk_hockey.AutoSize = true;
            this.chk_hockey.Location = new System.Drawing.Point(73, 144);
            this.chk_hockey.Name = "chk_hockey";
            this.chk_hockey.Size = new System.Drawing.Size(63, 17);
            this.chk_hockey.TabIndex = 2;
            this.chk_hockey.Text = "Hockey";
            this.chk_hockey.UseVisualStyleBackColor = true;
            this.chk_hockey.CheckedChanged += new System.EventHandler(this.chk_hockey_CheckedChanged);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(73, 197);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(0, 13);
            this.lbl_data.TabIndex = 3;
            // 
            // checkboxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.chk_hockey);
            this.Controls.Add(this.chk_cricket);
            this.Controls.Add(this.chk_carrom);
            this.Name = "checkboxDemo";
            this.Text = "checkboxDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_carrom;
        private System.Windows.Forms.CheckBox chk_cricket;
        private System.Windows.Forms.CheckBox chk_hockey;
        private System.Windows.Forms.Label lbl_data;
    }
}