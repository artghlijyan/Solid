using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    class SmartWatch_2 : SmartWatch_1
    {
        Step step;

        public SmartWatch_2()
        {
            step = new Step();
        }

        public override void On()
        {
            base.On();
            step.ShowSteps();
        }
    }
}
