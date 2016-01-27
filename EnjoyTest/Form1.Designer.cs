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
            this.components = new System.ComponentModel.Container();
            this.uniteMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行脚本RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最近文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AFG3022AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraTabbedMdiManager1 = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAFG = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.uniteMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uniteMenu
            // 
            this.uniteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deviceToolStripMenuItem});
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
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AFG3022AToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // AFG3022AToolStripMenuItem
            // 
            this.AFG3022AToolStripMenuItem.Name = "AFG3022AToolStripMenuItem";
            this.AFG3022AToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AFG3022AToolStripMenuItem.Text = "AFG3022(&A)";
            this.AFG3022AToolStripMenuItem.Click += new System.EventHandler(this.AFG3022AToolStripMenuItem_Click);
            // 
            // ultraTabbedMdiManager1
            // 
            this.ultraTabbedMdiManager1.AllowNestedTabGroups = Infragistics.Win.DefaultableBoolean.True;
            this.ultraTabbedMdiManager1.MdiParent = this;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonAFG,
            this.toolStripButtonExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::EnjoyTest.Properties.Resources.imageres_3;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "toolStripButtonOpen";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonAFG
            // 
            this.toolStripButtonAFG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAFG.Image = global::EnjoyTest.Properties.Resources.imageres_35;
            this.toolStripButtonAFG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAFG.Name = "toolStripButtonAFG";
            this.toolStripButtonAFG.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAFG.Text = "toolStripButton2";
            this.toolStripButtonAFG.Click += new System.EventHandler(this.toolStripButtonAFG_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::EnjoyTest.Properties.Resources.imageres_105;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExit.Text = "toolStripButtonExit";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.uniteMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.uniteMenu;
            this.Name = "mainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.uniteMenu.ResumeLayout(false);
            this.uniteMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uniteMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行脚本RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最近文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AFG3022AToolStripMenuItem;
        private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager ultraTabbedMdiManager1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonAFG;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
    }
}

