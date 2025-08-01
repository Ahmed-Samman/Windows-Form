using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Notification Title";
            notifyIcon1.BalloonTipText = "This is a sample notification message.";
            notifyIcon1.ShowBalloonTip(3000); // Show for 3 seconds
        }

      
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Balloon tip clicked!");
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Balloon tip Closed!");
        }
    }



}
