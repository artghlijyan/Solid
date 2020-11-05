namespace LSP
{
    class ContractEmployee : Employee // IEmployeeBonus
    {
        public ContractEmployee() { }

        public ContractEmployee(int id, string name) : base(id, name) { }

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
