using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{           
    class TimeAndTemperature //Breaks Solid's <S>
    {
        string time;
        int temp;

        public void ShowTimeAndTemp()
        {
            temp = 22;
            time = DateTime.Now.ToString();
            string result = $"Time is {time},\nTemperature is {temp}";
            Console.WriteLine(result);
        }
    }
}
