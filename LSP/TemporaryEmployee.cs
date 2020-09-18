using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() { }

        public TemporaryEmployee(int id, string name) : base(id, name) { }

        //public override decimal CalcBonus(decimal salary)
        //{
        //    return (salary * 0.05M);
        //}

        public override decimal GetSalery()
        {
            return 5000;
        }
    }
}
