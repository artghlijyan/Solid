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
        private int _buttonCount;

        Time time;
        Temperature temp;

        public SmartWatch()
        {
            time = new Time();
            temp = new Temperature();
        }

        public string Button_Click()
        {
            string result = string.Empty;

            ButtonCounter();

            if (_buttonCount > 2)
            {
                ResetButtonCount();
                ButtonCounter();
            }

            switch (_buttonCount)
            {
                case 1:
                    {
                        result = time.ShowTime();
                        result = string.Format("Time: {0}", result);
                        break;
                    }
                case 2:
                    {
                        result = temp.ShowTemp();
                        result = string.Format("Temerature: {0}", result);
                        break;
                    }
            }

            return result;
        }

        private void ResetButtonCount()
        {
            _buttonCount = 0;
        }

        private void ButtonCounter()
        {
            _buttonCount++;
        }
    }
}
