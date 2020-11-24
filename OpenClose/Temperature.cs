using System;

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
