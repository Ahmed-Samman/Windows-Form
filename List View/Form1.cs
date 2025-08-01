using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtID.Text))
                return;
            
            ListViewItem item = new ListViewItem(txtID.Text.Trim());

            if (rbtnMale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;
            
            item.SubItems.Add(txtName.Text.Trim());
            item.SubItems.Add(txtPhoneNum.Text.Trim());
            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtPhoneNum.Clear();
            txtID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count == 0)
                return;
                       
            int IndexToDelete = listView1.SelectedIndices.Count > 0 ? listView1.SelectedIndices[0] 
                : listView1.Items.Count - 1; // Default to the last item if none selected

            listView1.Items.RemoveAt(IndexToDelete);            
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                if (i % 2 == 0)
                    item.ImageIndex = 0;
                else
                    item.ImageIndex = 1;

                item.SubItems.Add("Person " + i.ToString());
                listView1.Items.Add(item);
            }
        }


        private void rbtnDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
        private void rbtnSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
        private void rbtnTitle_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
        private void rbtnLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }
        private void rbtnList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
