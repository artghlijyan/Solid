using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    class WatchButton
    {
        SmartWatch device;

        public WatchButton()
        {
            this.device = new SmartWatch();
        }

        public void UseDevice()
        {
            device.On();
        }
    }
}
