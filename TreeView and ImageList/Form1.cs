using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_and_ImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // treeview 1
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = e.Node.Text; 
        }
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }
        private void CheckTreeViewNode(TreeNode Node, Boolean isChecked)
        {
            foreach (TreeNode item in Node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }
            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }



        // treeview 2
        private void btnAdd_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Add("Porgramming Languages");
            treeView2.Nodes.Add("Web Site");
            treeView2.Nodes.Add("Computer Devices");

            // Programming Languages
            treeView2.Nodes[0].Nodes.Add("C#");

            treeView2.Nodes[0].Nodes.Add("Java");
            treeView2.Nodes[0].Nodes[1].Nodes.Add("Java SE");
            treeView2.Nodes[0].Nodes[1].Nodes.Add("Java EE");

            treeView2.Nodes[0].Nodes.Add("C++");

            // Web Site
            treeView2.Nodes[1].Nodes.Add("HTML");
            treeView2.Nodes[1].Nodes.Add("CSS");
            treeView2.Nodes[1].Nodes.Add("JS");

            // Computer Devicee


        }
        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = treeView2.SelectedNode.Text;   // Or   label1.Text = e.Node.Text;
        }
        private void btnCopySelect_Click(object sender, EventArgs e)
        {

            txtSelected.Clear();


            foreach (TreeNode tn in treeView2.Nodes)
            {
                if (tn.Checked)
                {
                    txtSelected.Text += tn.Text + txtEnter.Text;
                }
               
                if (tn.Nodes.Count > 0)
                {
                    foreach (TreeNode tn2 in tn.Nodes)
                    {
                        if (tn2.Checked)
                            txtSelected.Text += "     " + tn2.Text + txtEnter.Text;

                        if (tn2.Nodes.Count > 0)
                        {
                            foreach (TreeNode tn3 in tn2.Nodes)
                            {
                                if (tn3.Checked)
                                    txtSelected.Text += "         " + tn3.Text + txtEnter.Text;

                            }
                        }
                    }
                }
            }
        }



        // TreeView 3  (Short Way To Add Nodes)
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            treeView3.Nodes.Add("PL").Nodes.Add("Java").Parent.Nodes.Add("C#").Parent.Nodes.Add("C++");

            treeView3.Nodes.Add("Web Site").Nodes.Add("HTML").Parent.Nodes.Add("CSS").Parent.Nodes.Add("JS");

        }

        
    }
}
