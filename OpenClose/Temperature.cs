using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    class Temperature
    {
        int temp;

        public void ShowTemp()
        {
            temp = 22;
            string result = $"Temperature is {temp}";
            Console.WriteLine(result);
        }
    }
}
