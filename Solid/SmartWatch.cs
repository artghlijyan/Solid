using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    class SmartWatch
    {
        //Breaks Solid's <S>
        //TimeAndTemperature timeAndTemp;

        //public Device()
        //{
        //    timeAndTemp = new TimeAndTemperature();
        //}

        //public void On()
        //{
        //    timeAndTemp.DoWork();
        //}

        Time time;
        Temperature temp;

        public SmartWatch()
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
