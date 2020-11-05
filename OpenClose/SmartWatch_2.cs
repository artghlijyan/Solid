using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    class SmartWatch_2 : ISmartWatch // SmartWatch_1
    {
        Step step;
        ISmartWatch smartWatch_1;

        public SmartWatch_2()
        {
            smartWatch_1 = new SmartWatch_1();
            step = new Step();
        }

        public void On()
        {
            // base.On(); -> in case of Inheritance
            smartWatch_1.On();
            step.ShowSteps();
        }
    }
}
