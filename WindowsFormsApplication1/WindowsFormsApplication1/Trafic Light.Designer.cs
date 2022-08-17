namespace WindowsFormsApplication1
{
    partial class Trafic_Light
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
            this.components = new System.ComponentModel.Container();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_stop = new System.Windows.Forms.Label();
            this.lbl_waite = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.BackColor = System.Drawing.Color.Red;
            this.lbl_start.Location = new System.Drawing.Point(94, 39);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(29, 13);
            this.lbl_start.TabIndex = 0;
            this.lbl_start.Text = "Start";
            this.lbl_start.Visible = false;
            this.lbl_start.Click += new System.EventHandler(this.lbl_start_Click);
            // 
            // lbl_stop
            // 
            this.lbl_stop.AutoSize = true;
            this.lbl_stop.BackColor = System.Drawing.Color.Lime;
            this.lbl_stop.Location = new System.Drawing.Point(94, 84);
            this.lbl_stop.Name = "lbl_stop";
            this.lbl_stop.Size = new System.Drawing.Size(29, 13);
            this.lbl_stop.TabIndex = 1;
            this.lbl_stop.Text = "Stop";
            this.lbl_stop.Visible = false;
            this.lbl_stop.Click += new System.EventHandler(this.lbl_stop_Click);
            // 
            // lbl_waite
            // 
            this.lbl_waite.AutoSize = true;
            this.lbl_waite.BackColor = System.Drawing.Color.Yellow;
            this.lbl_waite.Location = new System.Drawing.Point(94, 126);
            this.lbl_waite.Name = "lbl_waite";
            this.lbl_waite.Size = new System.Drawing.Size(35, 13);
            this.lbl_waite.TabIndex = 2;
            this.lbl_waite.Text = "Waite";
            this.lbl_waite.Click += new System.EventHandler(this.lbl_waite_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(30, 198);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(155, 198);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(194, 84);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Status";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Trafic_Light
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_waite);
            this.Controls.Add(this.lbl_stop);
            this.Controls.Add(this.lbl_start);
            this.Name = "Trafic_Light";
            this.Text = "Trafic_Light";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_stop;
        private System.Windows.Forms.Label lbl_waite;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer1;
    }
}