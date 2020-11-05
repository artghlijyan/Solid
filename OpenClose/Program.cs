using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {

            ISmartWatch oldWatch = new SmartWatch_1();
            ISmartWatch newWatch = new SmartWatch_2();

            oldWatch.On();
            newWatch.On();
        }
    }
}
