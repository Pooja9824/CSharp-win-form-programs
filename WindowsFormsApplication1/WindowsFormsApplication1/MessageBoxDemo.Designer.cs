namespace WindowsFormsApplication1
{
    partial class MessageBoxDemo
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
            this.btn_messagebox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_messagebox
            // 
            this.btn_messagebox.Location = new System.Drawing.Point(80, 122);
            this.btn_messagebox.Name = "btn_messagebox";
            this.btn_messagebox.Size = new System.Drawing.Size(117, 23);
            this.btn_messagebox.TabIndex = 0;
            this.btn_messagebox.Text = "MessageBox Demo";
            this.btn_messagebox.UseVisualStyleBackColor = true;
            this.btn_messagebox.Click += new System.EventHandler(this.btn_messagebox_Click);
            // 
            // MessageBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_messagebox);
            this.Name = "MessageBoxDemo";
            this.Text = "MessageBoxDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_messagebox;
    }
}