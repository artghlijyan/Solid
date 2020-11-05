namespace LSP
{
    class TemporaryEmployee : Employee, IEmployeeBonus
    {
        decimal bonusRatio = 0.05M;

        public TemporaryEmployee() { }

        public TemporaryEmployee(int id, string name) : base(id, name) { }

        //public override decimal CalcBonus(decimal salary)
        //{
        //    return (salary * 0.05M);
        //}

        public decimal CalcBonus(decimal salary)
        {
            return (salary * bonusRatio);
        }

        public override decimal GetSalery()
        {
            return 5000;
        }
    }
}
