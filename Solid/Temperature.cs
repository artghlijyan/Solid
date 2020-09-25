using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    class Temperature
    {
        int temp;

        public string ShowTemp()
        {
            return (temp = 22).ToString();
        }
    }
}
