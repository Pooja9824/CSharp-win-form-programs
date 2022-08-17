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
    public partial class TreeViewDemo : Form
    {
        public TreeViewDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node;
            node = treeView1.Nodes.Add("Fruit");
            node.Nodes.Add("Apple");
            node.Nodes.Add("Mango");
            node = treeView1.Nodes.Add("Vegetable");
            node.Nodes.Add("Tomato");
            node.Nodes.Add("Potato");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Sort();
        }
    }
}
