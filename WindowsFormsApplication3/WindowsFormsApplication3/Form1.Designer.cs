namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.cmb_country = new System.Windows.Forms.ComboBox();
            this.cmb_state = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // cmb_country
            // 
            this.cmb_country.FormattingEnabled = true;
            this.cmb_country.Location = new System.Drawing.Point(146, 39);
            this.cmb_country.Name = "cmb_country";
            this.cmb_country.Size = new System.Drawing.Size(121, 21);
            this.cmb_country.TabIndex = 3;
            this.cmb_country.SelectedIndexChanged += new System.EventHandler(this.cmb_country_SelectedIndexChanged);
            // 
            // cmb_state
            // 
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.Location = new System.Drawing.Point(146, 77);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.Size = new System.Drawing.Size(121, 21);
            this.cmb_state.TabIndex = 4;
            this.cmb_state.SelectedIndexChanged += new System.EventHandler(this.cmb_state_SelectedIndexChanged);
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(146, 113);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(121, 21);
            this.cmb_city.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.cmb_state);
            this.Controls.Add(this.cmb_country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_country;
        private System.Windows.Forms.ComboBox cmb_state;
        private System.Windows.Forms.ComboBox cmb_city;
    }
}

