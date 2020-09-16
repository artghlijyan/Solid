using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class Device
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

        public Device()
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
