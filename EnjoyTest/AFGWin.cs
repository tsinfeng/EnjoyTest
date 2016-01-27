using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Diagnostics;
using System.Threading;
using LuaInterface;
using System.IO;
using System.IO.Ports;

namespace EnjoyTest
{
    public partial class AFGWin : Form
    {
        Thread threadLuaRunner;
        Meter meter = new Meter();

        public AFGWin()
        {
            InitializeComponent();
        }

        public void OutputLine(string text)
        {
            System.Console.WriteLine(text);
        }
        public void Sleep(int time)
        {
            Thread.Sleep(time);
        }
        public void FMSignal(int channel, float carrier, float low, float offset, float ampl)
        {
            AFG3022.GetInstance().FMSignal(channel, carrier, low, offset, ampl);
        }

        public void Offset(int channel, float ampl)
        {
            AFG3022.GetInstance().Offset(channel, ampl);
        }

        public void Single(int channel, float freq, float ampl)
        {
            AFG3022.GetInstance().Single(channel, freq, ampl);
        }
        public void Output(int channel, bool state)
        {
            AFG3022.GetInstance().Output(channel, state);
        }
        //万用表串口的调用
        public void SetAcVolt()
        {
            meter.SetAcVolt();
        }
        public void SetDcVolt()
        {
            meter.SetDcVolt();
        }
        public void SetAcCurrent()
        {
            meter.SetAcCurrent();
        }
        public void SetDcCurrent()
        {
            meter.SetDcCurrent();
        }
        public float MeterValue()
        {
            return Meter.MeterReadingValue;
        }



        private void RunLua(object obj)
        {
            try
            {
                string luaFile = obj as string;
                Lua luaVM = new Lua();

                luaVM.RegisterFunction("FMSignal", this, this.GetType().GetMethod("FMSignal"));
                luaVM.RegisterFunction("Single", this, this.GetType().GetMethod("Single"));
                luaVM.RegisterFunction("Output", this, this.GetType().GetMethod("Output"));
                luaVM.RegisterFunction("OutputLine", this, this.GetType().GetMethod("OutputLine"));
                luaVM.RegisterFunction("Sleep", this, this.GetType().GetMethod("Sleep"));
                luaVM.RegisterFunction("SetAcVolt", this, this.GetType().GetMethod("SetAcVolt"));
                luaVM.RegisterFunction("SetDcVolt", this, this.GetType().GetMethod("SetDcVolt"));
                luaVM.RegisterFunction("SetAcCurrent", this, this.GetType().GetMethod("SetAcCurrent"));
                luaVM.RegisterFunction("SetDcCurrent", this, this.GetType().GetMethod("SetDcCurrent"));
                luaVM.RegisterFunction("MeterValue", this, this.GetType().GetMethod("MeterValue"));

                luaVM.DoFile(luaFile);


                luaVM.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                this.Invoke(new MethodInvoker(delegate
                {

                    this.buttonLuaRun.Text = "运行脚本";
                }));
            }

        }

        private void buttonCFSend_Click(object sender, EventArgs e)
        {
            float carrier = float.Parse(textBoxCarrierFre.Text);
            float lowFreq = float.Parse(textBoxLowFre.Text);
            float freqDiff = float.Parse(textBoxFreOffset.Text);
            float ampl = float.Parse(textBoxCRange.Text);
            AFG3022.GetInstance().FMSignal(1, carrier, lowFreq, freqDiff, ampl);
        }

        private void buttonSFSend_Click(object sender, EventArgs e)
        {
            float freq = float.Parse(textBoxSingleFre.Text);
            float ampl = float.Parse(textBoxSRange.Text);
            AFG3022.GetInstance().Single(1, freq, ampl);
        }

        private void buttonACsend_Click(object sender, EventArgs e)
        {
            AFG3022.GetInstance().Offset(1, float.Parse(textBoxOffset.Text));
        }

        private void buttonLuaRun_Click(object sender, EventArgs e)
        {
            if (threadLuaRunner == null || (threadLuaRunner.IsAlive == false))
            {

                if (false == HelperApi.ConsoleShow.consoleState)
                {
                    HelperApi.ConsoleShow pConsoleShow = new HelperApi.ConsoleShow();
                    pConsoleShow.CsAllocConsole();
                }
                else
                {
                    System.Console.WriteLine("Lua Running!");
                }



                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = false;
                ofd.Filter = "LuaScript|*.lua";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    threadLuaRunner = new Thread(new ParameterizedThreadStart(RunLua));

                    threadLuaRunner.IsBackground = true;
                    threadLuaRunner.Start(ofd.FileName);
                    this.buttonLuaRun.Text = "停止脚本";

                }

            }
            else
            {
                threadLuaRunner.Abort();
                this.buttonLuaRun.Text = "Run Lua";

            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (comboBoxSerials.Text != "")
            {
                if (meter.IsOpen() == false)
                {
                    buttonOpen.Text = "关闭串口";
                    comboBoxSerials.Enabled = false;
                    meter.PortName = comboBoxSerials.Text;
                    meter.Run();
                }
                else
                {
                    comboBoxSerials.Enabled = true;
                    buttonOpen.Text = "打开串口";
                    buttonOpen.Enabled = true;
                    try
                    {
                        meter.Stop();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
