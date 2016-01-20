namespace EnjoyTest
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uniteMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniteMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uniteMenu
            // 
            this.uniteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.uniteMenu.Location = new System.Drawing.Point(0, 0);
            this.uniteMenu.Name = "uniteMenu";
            this.uniteMenu.Size = new System.Drawing.Size(1008, 25);
            this.uniteMenu.TabIndex = 0;
            this.uniteMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.app1ToolStripMenuItem,
            this.app2ToolStripMenuItem,
            this.app3ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // app1ToolStripMenuItem
            // 
            this.app1ToolStripMenuItem.Name = "app1ToolStripMenuItem";
            this.app1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.app1ToolStripMenuItem.Text = "App1";
            this.app1ToolStripMenuItem.Click += new System.EventHandler(this.app1ToolStripMenuItem_Click);
            // 
            // app2ToolStripMenuItem
            // 
            this.app2ToolStripMenuItem.Name = "app2ToolStripMenuItem";
            this.app2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.app2ToolStripMenuItem.Text = "App2";
            this.app2ToolStripMenuItem.Click += new System.EventHandler(this.app2ToolStripMenuItem_Click);
            // 
            // app3ToolStripMenuItem
            // 
            this.app3ToolStripMenuItem.Name = "app3ToolStripMenuItem";
            this.app3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.app3ToolStripMenuItem.Text = "App3";
            this.app3ToolStripMenuItem.Click += new System.EventHandler(this.app3ToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.uniteMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.uniteMenu;
            this.Name = "mainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.uniteMenu.ResumeLayout(false);
            this.uniteMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uniteMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem app1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem app2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem app3ToolStripMenuItem;
    }
}

