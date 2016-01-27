using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.VisaNS;

namespace EnjoyTest
{
    class AFG3022
    {
        #region AC码型定义
        private static UInt16[][] jljsTime = new UInt16[][]{
                                   new UInt16[]  {350,120,220,120,220,570},//1.6
                                   new UInt16[]  {380,120,380,720},//1.6
                                   new UInt16[]  {230,570,230,570},//1.6
                                   new UInt16[]  {340,120,220,120,220,580},//1.6
                                   new UInt16[]  {440,120,460,580},//1.6
                                   new UInt16[]  {580,120,320,580},//1.6
                                   new UInt16[]  {220,580,220,580},//1.6
                                   new UInt16[]  {350,120,250,120,250,810},//1.9
                                   new UInt16[]  {350,120,620,810},//1.9
                                   new UInt16[]  {300,650,300,650},//1.9
                                   new UInt16[]  {360,120,240,120,240,840},//1.92
                                   new UInt16[]  {480,120,720,600},//1.92
                                   new UInt16[]  {620,120,580,600},//1.92
                                   new UInt16[]  {300,660,300,660},//1.92
                                   new UInt16[]  {220,120,340,120,220,580},//1.6
                                   new UInt16[]  {240,120,360,120,240,840},//1.92
                                   };
        #endregion

        private MessageBasedSession session = null;

        private static AFG3022 afg3022 = null;

        private AFG3022()
        {
            string[] resources = ResourceManager.GetLocalManager().FindResources("USB?*INSTR");

            if (resources != null && resources.Length > 0)
            {
                session = (MessageBasedSession)ResourceManager.GetLocalManager().Open(resources[0]);
            }

        }

        public static AFG3022 GetInstance()
        {
            if (afg3022 == null)
            {
                afg3022 = new AFG3022();
            }
            return afg3022;
        }


        public void FMSignal(int SourceNum, float carrier, float low, float offset, float ampl)
        {
            session.Write("SOURce" + SourceNum + ":FUNCtion:SHAPe SIN");
            session.Write("SOURce" + SourceNum + ":FREQuency:FIXed " + carrier);
            session.Write("SOURce" + SourceNum + ":VOLTage:UNIT VRMS");
            session.Write("SOURce" + SourceNum + ":VOLTage:LEVel:IMMediate:AMPLitude " + ampl);
            session.Write("SOURce" + SourceNum + ":FM:INTernal:FUNCtion SQUare");
            session.Write("SOURce" + SourceNum + ":FM:INTernal:FREQuency " + low);
            session.Write("SOURce" + SourceNum + ":FM:DEViation " + offset);
            session.Write("SOURce" + SourceNum + ":FM:STATe ON");

        }


        public void Single(int channel, float freq, float ampl)
        {
            session.Write("SOUR" + channel + ":FM:STATE OFF");
            session.Write("SOURce" + channel + ":FUNCtion:SHAPe SIN");
            session.Write("SOURce" + channel + ":VOLTage:UNIT VRMS");
            session.Write("SOURce" + channel + ":FREQuency:FIXed " + freq);
            session.Write("SOURce" + channel + ":VOLTage:LEVel:IMMediate:AMPLitude " + ampl + "\r\n");
        }


        public void JLJS()
        {

        }

        public void Offset(int channel, float offset)
        {
            session.Write("SOURce" + channel + ":VOLTage:LEVel:IMMediate:OFFSet " + offset);
        }

        public void Output(int channel, bool state)
        {
            if (state)
            {
                session.Write("OUTPut" + channel + " ON");
            }
            else
            {
                session.Write("OUTPut" + channel + " OFF");
            }

        }

    }
}
