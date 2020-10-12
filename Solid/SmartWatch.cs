using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    class SmartWatch
    {
        //Breaks Solid's <S>
        //TimeAndTemperature timeAndTemp;

        //public SmartWatch()
        //{
        //    timeAndTemp = new TimeAndTemperature();
        //}

        //public void On()
        //{
        //    timeAndTemp.ShowTimeAndTemp();
        //}

        Time time;
        Temperature temp;

        public SmartWatch()
        {
            time = new Time();
            temp = new Temperature();
        }
    }
}
