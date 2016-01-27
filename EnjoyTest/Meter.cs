using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Collections;
using System.Windows.Forms;


namespace EnjoyTest
{
    public class Meter
    {
        SerialPort sp = new SerialPort();
        //Thread sampleThread = null;
        ArrayList valueListeners = new ArrayList();
        //String cmdStr = null;

        public Meter()
            : this("COM2")
        {

        }
        public string PortName
        {
            get
            {
                return sp.PortName;
            }
            set
            {
                sp.PortName = value;
            }
        }

        public static float MeterReadingValue
        {
            get;
            set;

        }
        public Meter(string port)
        {
            sp.PortName = port;
        }




        string readResult = "";

        AutoResetEvent readEvent = new AutoResetEvent(false);

        string readResult2 = "";

        AutoResetEvent readEvent2 = new AutoResetEvent(false);


        void ReadProc()
        {

            sp.WriteLine("SYST:REM");
            Thread.Sleep(1500);

            sp.WriteLine("*CLS");
            Thread.Sleep(1500);
            sp.WriteLine("CONF:VOLT:AC");

            byte[] readBuffer = new byte[512];
            byte[] readItem = new byte[512];
            int itemLen = 0;
            try
            {


                while (true)
                {
                    int length = sp.Read(readBuffer, 0, readBuffer.Length);

                    for (int i = 0; i < length; i++)
                    {
                        readItem[itemLen] = readBuffer[i];
                        itemLen++;

                        if ((readBuffer[i] == 0x0a) && (itemLen >= 2) && (readItem[itemLen - 2] == 0x0d))
                        {

                            if (itemLen > 2)
                            {

                                lock (this)
                                {
                                    readResult = ASCIIEncoding.ASCII.GetString(readItem, 0, itemLen - 2);
                                    // Console.WriteLine(readResult);
                                    readResult2 = readResult;
                                }
                                readEvent.Set();
                                readEvent2.Set();
                            }

                            itemLen = 0;
                        }

                        if (itemLen >= readItem.Length)
                        {
                            itemLen = 0;
                        }
                    }

                }

            }
            catch (Exception)
            {

            }

        }

        void CmdProc()
        {
            try
            {

                Thread.Sleep(5000);

                while (true)
                {
                    Thread.Sleep(1000);

                    string cmd = "";
                    lock (listCmd)
                    {
                        if (listCmd.Count > 0)
                        {
                            cmd = listCmd.Dequeue();
                        }
                    }

                    if (cmd != "")
                    {
                        sp.WriteLine(cmd);
                    }
                    else
                    {
                        sp.WriteLine("*CLS");
                        Thread.Sleep(500);
                        sp.WriteLine("READ?");

                        float res = 0;
                        if (GetTestValue(out res, 2000))
                        {
                            Meter.MeterReadingValue = res;
                        }
                        else
                        {
                            sp.WriteLine("*CLS");
                        }
                    }
                }

            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }



        private bool GetTestValue(out float val, int timeout)
        {

            val = 0;
            if (readEvent2.WaitOne(timeout, false))
            {
                lock (this)
                {
                    if (float.TryParse(readResult2, out val))
                        return true;
                }
            }

            return false;
        }

        public bool ReadValue(out float val, int outTime)
        {
            val = 0;
            if (readEvent.WaitOne(outTime, false))
            {
                lock (this)
                {
                    val = float.Parse(readResult);
                }

                return true;
            }

            return false;
        }
        public bool IsOpen()
        {
            return sp.IsOpen;
        }
        public void Stop()
        {
            if (rdThread != null && rdThread.IsAlive)
            {
                rdThread.Abort();
            }
            if (cmdThread != null && cmdThread.IsAlive)
            {
                cmdThread.Abort();
            }

            sp.Close();
        }

        Queue<string> listCmd = new Queue<string>();

        public void WriteCmd(String str)
        {
            lock (listCmd)
            {
                listCmd.Enqueue(str);
            }
        }

        public void SetAcVolt()
        {
            WriteCmd("CONF:VOLT:AC");
        }
        public void SetDcVolt()
        {
            WriteCmd("CONF:VOLT:DC");
        }

        public void SetAcCurrent()
        {
            WriteCmd("CONF:CURR:AC");
        }
        public void SetDcCurrent()
        {
            WriteCmd("CONF:CURR:DC");
        }



        Thread cmdThread = null;
        Thread rdThread = null;

        public void Run()
        {

            if (sp.IsOpen) return;

            try
            {
                sp.Open();
                sp.DtrEnable = true;


                if (rdThread == null || rdThread.IsAlive == false)
                {
                    rdThread = new Thread(new ThreadStart(ReadProc));
                    rdThread.IsBackground = true;
                    rdThread.Start();


                }

                if (cmdThread == null || cmdThread.IsAlive == false)
                {
                    cmdThread = new Thread(new ThreadStart(CmdProc));
                    cmdThread.IsBackground = true;
                    cmdThread.Start();


                }


            }
            catch (Exception)
            {

            }


        }


    }
}
