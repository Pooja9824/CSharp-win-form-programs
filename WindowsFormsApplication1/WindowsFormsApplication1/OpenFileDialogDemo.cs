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
    public partial class OpenFileDialogDemo : Form
    {
        public OpenFileDialogDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:";
            ofd.Filter = "Text Files | *.txt;*.doc" ;
            ofd.Multiselect = true;
            ofd.ShowDialog();

         
            foreach(String fnm in ofd.FileNames)
            {

                MessageBox.Show(fnm);
            }
         
        }

        private void OpenFileDialogDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
