using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnjoyTest
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void app1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App1 appForm1 = new App1();
            appForm1.MdiParent = this;
            appForm1.Show();
            appForm1.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void app2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App2 appForm2 = new App2();
            appForm2.MdiParent = this;
            appForm2.Show();
            appForm2.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void app3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App3 appForm3 = new App3();
            appForm3.MdiParent = this;
            appForm3.Show();
            appForm3.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
