using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace EnjoyTest
{
    public partial class mainForm : Form
    {
        //static string sSaveFilePath = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string filePath = System.Environment.CurrentDirectory;
            filePath += "\\" + "Menu.ini";
            StreamReader srReader = new StreamReader(filePath);
            int i = this.fileToolStripMenuItem.DropDownItems.Count - 1;

            while (srReader.Peek() >= 0)
            {
                ToolStripMenuItem tsmiItems = new ToolStripMenuItem(srReader.ReadLine());
                this.fileToolStripMenuItem.DropDownItems.Insert(i, tsmiItems);
                i++;
                tsmiItems.Click += new EventHandler(tsmiItems_Click);
            }
            srReader.Close();
        }

        private void tsmiItems_Click(object sender, EventArgs e)
        {

        }

        private void 打开脚本RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "All files (*.*)|*.*|Lua files (*.lua)|*.lua|Bat files (*.bat)|*.bat|Python files (*.py)|*.py";
            LinkedList<string> linklistLines = new LinkedList<string>();
            string filePath = System.Environment.CurrentDirectory;
            filePath += "\\" + "Menu.ini";

            //push stack
            StreamReader srReader = new StreamReader(filePath);
            int i = 0;
            while (srReader.Peek() >= 0)
            {
                //stack.Push(srReader.ReadLine());
                linklistLines.AddLast(srReader.ReadLine());
                i++;
                if (i >= 5)
                    break;
            }
            srReader.Close();
      
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //threadLuaRunner = new Thread(new ParameterizedThreadStart(RunLua));

                //threadLuaRunner.IsBackground = true;
                //threadLuaRunner.Start(ofd.FileName);
                
                LinkedListNode<string> current = linklistLines.Find(ofd.FileName);
                if (null != current)
                {
                    linklistLines.Remove(current);
                    linklistLines.AddFirst(ofd.FileName);
                }
                else
                {
                    linklistLines.AddFirst(ofd.FileName);
                }

                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                fs.SetLength(0);
                fs.Close();

                StreamWriter swWriter = new StreamWriter(filePath, true);
                i = 0;
                current = linklistLines.First;
                while (i < 5 && current != null)
                {
                    swWriter.WriteLine(current.Value);
                    i++;
                    current = current.Next;
                }
                linklistLines.Clear();
                swWriter.Flush();
                swWriter.Close();

                ScriptWin scriptWinForm = new ScriptWin(ofd.FileName);
                scriptWinForm.MdiParent = this;
                scriptWinForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                scriptWinForm.Show();

            }
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AFG3022AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AFGWin afgWin = new AFGWin();
            afgWin.MdiParent = this;
            afgWin.Text = "AFG3022";
            afgWin.Show();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            运行脚本RToolStripMenuItem.PerformClick();
        }

        private void toolStripButtonAFG_Click(object sender, EventArgs e)
        {
            AFG3022AToolStripMenuItem.PerformClick();
        }

        /*
        private void 保存修改SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog  ofd = new SaveFileDialog();
            ofd.Filter = "All files (*.*)|*.*|Lua files (*.lua)|*.lua|Bat files (*.bat)|*.bat|Python files (*.py)|*.py";
            
        }
        */
    }
}
