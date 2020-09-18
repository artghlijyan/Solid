using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    // never changed, but extendable
    class Client
    {
        public void UseDevice(SmartWatch_1 device)
        {
            device.On();
        }
    }
}
