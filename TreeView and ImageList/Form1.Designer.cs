namespace TreeView_and_ImageList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Adam", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Fares", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ali", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ahmed", 1, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Boys", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Huda", 0, 0);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Alia", 0, 0);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Girls", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.btnCopySelect = new System.Windows.Forms.Button();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(56, 115);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Adam";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node3";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Fares";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "NodBoy1";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Ali";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "NodBoy2";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Ahmed";
            treeNode5.BackColor = System.Drawing.Color.White;
            treeNode5.ForeColor = System.Drawing.Color.Red;
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "NodBoys";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Boys";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "NodGirl1";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Text = "Huda";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "NodGirl2";
            treeNode7.SelectedImageIndex = 0;
            treeNode7.Text = "Alia";
            treeNode8.ForeColor = System.Drawing.Color.Blue;
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "NodGirls";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Girls";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(327, 306);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "girl_146005 (1).png");
            this.imageList1.Images.SetKeyName(1, "2533719.png");
            // 
            // treeView2
            // 
            this.treeView2.CheckBoxes = true;
            this.treeView2.Location = new System.Drawing.Point(418, 115);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(351, 306);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "girl_146005 (1).png");
            this.imageList2.Images.SetKeyName(1, "2533719.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(501, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(1441, 63);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(151, 44);
            this.btnAdd2.TabIndex = 5;
            this.btnAdd2.Text = "Add 2";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(1314, 170);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(320, 318);
            this.treeView3.TabIndex = 4;
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(881, 110);
            this.txtSelected.Multiline = true;
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(372, 359);
            this.txtSelected.TabIndex = 6;
            // 
            // btnCopySelect
            // 
            this.btnCopySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopySelect.Location = new System.Drawing.Point(757, 60);
            this.btnCopySelect.Name = "btnCopySelect";
            this.btnCopySelect.Size = new System.Drawing.Size(151, 44);
            this.btnCopySelect.TabIndex = 7;
            this.btnCopySelect.Text = " <<";
            this.btnCopySelect.UseVisualStyleBackColor = true;
            this.btnCopySelect.Click += new System.EventHandler(this.btnCopySelect_Click);
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(961, 51);
            this.txtEnter.Multiline = true;
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(196, 32);
            this.txtEnter.TabIndex = 8;
            this.txtEnter.Text = "\r\n";
            this.txtEnter.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 584);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.btnCopySelect);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Button btnCopySelect;
        private System.Windows.Forms.TextBox txtEnter;
    }
}

