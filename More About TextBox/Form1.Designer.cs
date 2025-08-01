namespace More_About_TextBox
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
            this.txtPasswordChar = new System.Windows.Forms.TextBox();
            this.txtReadOnly = new System.Windows.Forms.TextBox();
            this.txtMaxLength = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTextAlign = new System.Windows.Forms.TextBox();
            this.txtMultiLine = new System.Windows.Forms.TextBox();
            this.txtWordWrap = new System.Windows.Forms.TextBox();
            this.txtLocked = new System.Windows.Forms.TextBox();
            this.txtDock = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtFocse = new System.Windows.Forms.TextBox();
            this.btnFocus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswordChar
            // 
            this.txtPasswordChar.Location = new System.Drawing.Point(57, 59);
            this.txtPasswordChar.Name = "txtPasswordChar";
            this.txtPasswordChar.PasswordChar = '*';
            this.txtPasswordChar.Size = new System.Drawing.Size(221, 26);
            this.txtPasswordChar.TabIndex = 0;
            this.txtPasswordChar.Text = "ffdfdfgnhhhgggg";
            this.txtPasswordChar.TextChanged += new System.EventHandler(this.txtPasswordChar_TextChanged);
            // 
            // txtReadOnly
            // 
            this.txtReadOnly.Location = new System.Drawing.Point(57, 159);
            this.txtReadOnly.Name = "txtReadOnly";
            this.txtReadOnly.ReadOnly = true;
            this.txtReadOnly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReadOnly.Size = new System.Drawing.Size(221, 26);
            this.txtReadOnly.TabIndex = 1;
            this.txtReadOnly.Text = "Ahmed Samman";
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Location = new System.Drawing.Point(57, 239);
            this.txtMaxLength.MaxLength = 5;
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(221, 26);
            this.txtMaxLength.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(221, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Right To Left";
            // 
            // txtTextAlign
            // 
            this.txtTextAlign.Location = new System.Drawing.Point(57, 385);
            this.txtTextAlign.Name = "txtTextAlign";
            this.txtTextAlign.Size = new System.Drawing.Size(221, 26);
            this.txtTextAlign.TabIndex = 4;
            this.txtTextAlign.Text = "Ahmed Samman";
            this.txtTextAlign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMultiLine
            // 
            this.txtMultiLine.Location = new System.Drawing.Point(378, 70);
            this.txtMultiLine.Multiline = true;
            this.txtMultiLine.Name = "txtMultiLine";
            this.txtMultiLine.Size = new System.Drawing.Size(298, 90);
            this.txtMultiLine.TabIndex = 5;
            this.txtMultiLine.Text = "MultiLine\r\nAhmed Samman\r\nSammedr Sammy\r\nAli Fahmi\r\n\r\n";
            this.txtMultiLine.TextChanged += new System.EventHandler(this.txtMultiLine_TextChanged);
            // 
            // txtWordWrap
            // 
            this.txtWordWrap.Location = new System.Drawing.Point(378, 182);
            this.txtWordWrap.Multiline = true;
            this.txtWordWrap.Name = "txtWordWrap";
            this.txtWordWrap.Size = new System.Drawing.Size(298, 65);
            this.txtWordWrap.TabIndex = 6;
            this.txtWordWrap.Text = "\r\n\r\n\r\n\r\n\r\n";
            this.txtWordWrap.WordWrap = false;
            this.txtWordWrap.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLocked
            // 
            this.txtLocked.Location = new System.Drawing.Point(378, 286);
            this.txtLocked.Name = "txtLocked";
            this.txtLocked.Size = new System.Drawing.Size(252, 26);
            this.txtLocked.TabIndex = 7;
            this.txtLocked.Text = "Locked";
            // 
            // txtDock
            // 
            this.txtDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDock.Location = new System.Drawing.Point(0, 0);
            this.txtDock.Name = "txtDock";
            this.txtDock.Size = new System.Drawing.Size(934, 26);
            this.txtDock.TabIndex = 8;
            this.txtDock.Text = "Dock";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(378, 342);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 90);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Border Style\r\nAhmed Samman\r\nSammedr Sammy\r\nAli Fahmi\r\n\r\n";
            // 
            // txtFocse
            // 
            this.txtFocse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFocse.Location = new System.Drawing.Point(212, 475);
            this.txtFocse.Multiline = true;
            this.txtFocse.Name = "txtFocse";
            this.txtFocse.Size = new System.Drawing.Size(298, 90);
            this.txtFocse.TabIndex = 10;
            this.txtFocse.Text = " ";
            this.txtFocse.UseWaitCursor = true;
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(253, 588);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(174, 42);
            this.btnFocus.TabIndex = 11;
            this.btnFocus.Text = " Focus()";
            this.btnFocus.UseVisualStyleBackColor = true;
            this.btnFocus.Click += new System.EventHandler(this.btnFocus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 689);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.txtFocse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDock);
            this.Controls.Add(this.txtLocked);
            this.Controls.Add(this.txtWordWrap);
            this.Controls.Add(this.txtMultiLine);
            this.Controls.Add(this.txtTextAlign);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMaxLength);
            this.Controls.Add(this.txtReadOnly);
            this.Controls.Add(this.txtPasswordChar);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordChar;
        private System.Windows.Forms.TextBox txtReadOnly;
        private System.Windows.Forms.TextBox txtMaxLength;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTextAlign;
        private System.Windows.Forms.TextBox txtMultiLine;
        private System.Windows.Forms.TextBox txtWordWrap;
        private System.Windows.Forms.TextBox txtLocked;
        private System.Windows.Forms.TextBox txtDock;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtFocse;
        private System.Windows.Forms.Button btnFocus;
    }
}

