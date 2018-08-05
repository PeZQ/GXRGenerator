using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace GenCSharp
{
    public class GenCSharp : IDisposable
    {
        public void Dispose()
        {
            checkTimer.Stop();
            IGenSysInterface.GICloseGenCommunication();
            checkTimer.Dispose();
            checkTimer = null;
        }

        Timer checkTimer = null;
        bool isConnected = false;
        bool isInited = false;
        public bool Init(IntPtr handle)
        {
            checkTimer = new Timer(800);
            checkTimer.Elapsed += CheckTimer_Elapsed;
            isInited = IGenSysInterface.GIInitGenerator(handle);
            checkTimer.Start();
            return isInited;
        }

        private void CheckTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            isConnected = IGenSysInterface.GICheckGenCommIsNormal();
        }

        public bool SetGenParam(APRSourceData scAPRSourceData)
        {
            bool ret = IGenSysInterface.GICheckGenAllowOperation();
            if (ret)
            {
                //设置曝光条件
                IGenSysInterface.GIApplyAPRData(scAPRSourceData);
            }
            return false;
        }
    }
}
