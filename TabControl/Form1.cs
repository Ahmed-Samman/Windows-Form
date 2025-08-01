using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComBoxCurses.SelectedIndex = 0;
        }
      
        private void btnAddDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) 
                || string.IsNullOrWhiteSpace(txtCollage.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
               return;

            ListViewItem item = new ListViewItem(txtID.Text);

            if (rbtnMale.Checked)
                item.SubItems.Add(rbtnMale.Text.Trim());
            else
                item.SubItems.Add(rbtnFemale.Text.Trim());


            item.SubItems.Add(txtName.Text.Trim());
            item.SubItems.Add(txtAge.Text.Trim());
            item.SubItems.Add(ComBoxCurses.Text.Trim());
            item.SubItems.Add(txtCollage.Text.Trim());
            item.SubItems.Add(txtPhone.Text.Trim());
            item.SubItems.Add(txtEmail.Text.Trim());

            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtAge.Clear();
            ComBoxCurses.SelectedIndex = 0;
            txtCollage.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

            txtID.Focus();
        }
  
        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFindStudent.Text))  
                return;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == txtFindStudent.Text)
                {
                    MessageBox.Show("This Student Is Already Find", "Find Student", MessageBoxButtons.OK);
                    return;
                }
            }
      
            MessageBox.Show("This Student Is Not Find!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }




    }
}
