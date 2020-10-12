using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {

            SmartWatch_1 oldWatch = new SmartWatch_1();
            SmartWatch_2 newWatch = new SmartWatch_2();

            oldWatch.On();
            newWatch.On();
        }
    }
}
