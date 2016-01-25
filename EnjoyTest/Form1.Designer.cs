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
            this.运行脚本RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存修改SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最近文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.运行脚本RToolStripMenuItem,
            this.保存修改SToolStripMenuItem,
            this.最近文件FToolStripMenuItem,
            this.退出XToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // 运行脚本RToolStripMenuItem
            // 
            this.运行脚本RToolStripMenuItem.Name = "运行脚本RToolStripMenuItem";
            this.运行脚本RToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.运行脚本RToolStripMenuItem.Text = "打开脚本(&R)";
            this.运行脚本RToolStripMenuItem.Click += new System.EventHandler(this.打开脚本RToolStripMenuItem_Click);
            // 
            // 保存修改SToolStripMenuItem
            // 
            this.保存修改SToolStripMenuItem.Name = "保存修改SToolStripMenuItem";
            this.保存修改SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存修改SToolStripMenuItem.Text = "保存修改(&S)";
            this.保存修改SToolStripMenuItem.Click += new System.EventHandler(this.保存修改SToolStripMenuItem_Click);
            // 
            // 最近文件FToolStripMenuItem
            // 
            this.最近文件FToolStripMenuItem.Name = "最近文件FToolStripMenuItem";
            this.最近文件FToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.最近文件FToolStripMenuItem.Text = "最近文件(&F)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出XToolStripMenuItem.Text = "退出(X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem 运行脚本RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最近文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存修改SToolStripMenuItem;
    }
}

