using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    class Time
    {
        string time;

        public void ShowTime()
        {
            time = DateTime.Now.ToString();
            string result = $"Time is {time},";
            Console.WriteLine(result);
        }
    }
}
