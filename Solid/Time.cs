using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    class Time
    {
        string time;

        public string ShowTime()
        {
            return time = DateTime.Now.ToString();
        }
    }
}
