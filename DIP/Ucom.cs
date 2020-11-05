using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class Ucom : IMobileOperator
    {
        const string operatorName = "Ucom";

        public string GetOperator(string number)
        {
            return $"{number} is {operatorName} Phone number";
        }
    }
}
