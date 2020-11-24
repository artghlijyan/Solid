using System;

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
