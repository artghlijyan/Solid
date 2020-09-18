using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    class ContractEmployee : Employee
    {
        public ContractEmployee() { }

        public ContractEmployee(int id, string name) : base(id, name) { }

        //breaks LSP 
        //public decimal CalcBonus(decimal salary)
        //{
        //    throw new NotImplementedException();
        //}

        public override decimal GetSalery()
        {
            return 10000;
        }
    }
}
