using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Threading;
using System.IO;
//using System.Threading;

namespace EnjoyTest
{
    public partial class ScriptWin : Form
    {
        string strFilePath;
        Process p = null;
        string sSaveFilePath;

        public ScriptWin(string path)
        {
            InitializeComponent();
            strFilePath = path;
            this.Text = path;
        }

        private void PrintLog(object obj_data)
        {
            string strData = obj_data as string;

            if (("" != sSaveFilePath) && (checkBoxSave.Enabled == true))
            {
                FileStream fs = new FileStream(sSaveFilePath, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine(strData);
                sw.Flush();
                sw.Close();
                fs.Close();

            }
            //threadPrintLog.Abort();
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            string[] strFile;
            string strType;
            strFile = strFilePath.Split('\\');
            strType = strFile.Last();
            strFile = strType.Split('.');
            strType = strFile.Last();

            //Process p = new System.Diagnostics.Process();
            p = new System.Diagnostics.Process();
            if (null == p)
                p = new System.Diagnostics.Process();
            switch (strType)
            {
                case "py":
                    p.StartInfo.FileName = @"python";
                    break;
                case "lua":
                    p.StartInfo.FileName = @"lua";
                    break;
                case "bat":
                    p.StartInfo.FileName = @"cmd";
                    strFilePath = @"/C " + strFilePath;
                    break;
                default:
                    MessageBox.Show("Unsupport script right now!");
                    break;
            }
            p.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
            p.ErrorDataReceived += new DataReceivedEventHandler(process_ErrorDataReceived);
            //strFilePath += " valid_q";
            p.StartInfo.Arguments = strFilePath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;     
            

            p.Start();
            textBox1.AppendText("Start...\n");
            //异步获取命令内容
            p.BeginOutputReadLine();
            //异步获取订阅事件
            //p.WaitForExit();
            buttonRun.Enabled = false;
        }
        private void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data) == false)
            {
                AppendText(e.Data + "\r\n");
            }
        }
        private void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data) == false)
            {
                //Console.WriteLine(e.Data);

                /*
                this.Invoke(new MethodInvoker(delegate {

                    this.textBox1.AppendText(e.Data + "\r\n");
                   
                }));
                 * */
                AppendText(e.Data + "\r\n");
                if (checkBoxSave.Checked == true)
                {
                    //threadPrintLog = new Thread(new ParameterizedThreadStart(PrintLog));
                    PrintLog(e.Data);
                }

                //Thread thread = new Thread(new ParameterizedThreadStart(AppendText));
                //thread.Start(e.Data);
            }
        }

        #region
        private delegate void AppendTextCallback(string text);

        private void AppendText(string text)
        {


            if (this.textBox1.InvokeRequired)
            {
                AppendTextCallback d = new AppendTextCallback(AppendText);
                //IAsyncResult result = this.textBox1.BeginInvoke(d, new object[] { text });
                try
                {
                    //d.EndInvoke(result);
                    textBox1.Invoke(d, new object[] { text });
                    //this.Invoke(d, new object[] {text });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //this.textBox1.Refresh();
                //string temp = textBox1.Text;
                //this.textBox1.Text = temp + text;
                //this.textBox1.Refresh();
                int lines = textBox1.GetLineFromCharIndex(textBox1.Text.Length) + 1;
                if (lines > 1000)
                {
                    textBox1.Text = textBox1.Text.Remove(0, textBox1.Text.IndexOf('\r') + 1);
                }


                textBox1.AppendText(text);

            }



        }
        #endregion

        private void buttonStop_Click(object sender, EventArgs e)
        {
            string[] strFile;
            string strType;
            strFile = strFilePath.Split('\\');
            strType = strFile.Last();
            strFile = strType.Split('.');
            strType = strFile.Last();
            string strFileName;

            
            //Process p = new System.Diagnostics.Process();
            if (null == p)
                return;
            switch (strType)
            {
                case "py":
                    strFileName = "python";
                    break;
                case "lua":
                    strFileName = "lua";
                    break;
                case "bat":
                    strFileName = "cmd"; ;
                    break;
                default:
                    MessageBox.Show("Unsupport script!");
                    return;
            }

            this.Cursor = Cursors.WaitCursor;
            Process[] myprocesses;
            myprocesses = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(strFileName));
            foreach (Process pTemp in myprocesses)
            {
                //通过向进程主窗口发送关闭消息达到关闭进程的目的
                pTemp.CloseMainWindow();
                //等待5000毫秒
                Thread.Sleep(2000);
                //释放与此组件关联的所有资源
                pTemp.Close();
            }
            
            //p.CloseMainWindow();
            p.CancelOutputRead();
            if (!p.HasExited)
            {
                p.Kill();
            }
            p.Dispose();
            p = null;
            this.Cursor = Cursors.Default;
            buttonRun.Enabled = true;
        }

        private void checkBoxSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked == true)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "所有文件|*.*|文本文件|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sSaveFilePath = saveFileDialog.FileName;

                }
            }
            else
            {
                sSaveFilePath = "";
            }
        }

        private void ScriptWin_Load(object sender, EventArgs e)
        {
        }

    }
}
