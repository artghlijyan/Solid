﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    class SmartWatch_1 : ISmartWatch
    {
        Time time;
        Temperature temp;

        public SmartWatch_1()
        {
            time = new Time();
            temp = new Temperature();
        }

        public void On()
        {
            time.ShowTime();
            temp.ShowTemp();
        }
    }
}
