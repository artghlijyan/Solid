using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    class PermanentEmployee : Employee, IEmployeeBonus
    {
        public PermanentEmployee() { }

        public PermanentEmployee(int id, string name) : base(id, name) { }

        public decimal CalcBonus(decimal salary)
        {
            return (salary * 0.1M);
        }

        public override decimal GetSalery()
        {
            return 8000;
        }
    }
}
