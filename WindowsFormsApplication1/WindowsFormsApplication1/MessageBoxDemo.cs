using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MessageBoxDemo : Form
    {
        public MessageBoxDemo()
        {
            InitializeComponent();
        }

        private void btn_messagebox_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("are you sure", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);

            if (d == DialogResult.Yes)
            {
                MessageBox.Show("U have passed yes");
            }
            else if (d == DialogResult.No)
            {
                MessageBox.Show("U have passed No");
            }
        }
    }
}
