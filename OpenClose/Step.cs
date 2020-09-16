using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    class Step
    {
        int steps;

        public void ShowSteps()
        {
            steps = 1000;
            Console.WriteLine("Today steps: " + steps);
        }
    }
}
