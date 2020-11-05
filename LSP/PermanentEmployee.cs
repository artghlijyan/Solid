namespace LSP
{
    class PermanentEmployee : Employee, IEmployeeBonus
    {
        decimal bonusRatio = 0.1M;

        public PermanentEmployee() { }

        public PermanentEmployee(int id, string name) : base(id, name) { }

        public decimal CalcBonus(decimal salary)
        {
            return (salary * bonusRatio);
        }

        //public override decimal CalcBonus(decimal salary)
        //{
        //    return (salary * 0.05M);
        //}

        public override decimal GetSalery()
        {
            return 8000;
        }
    }
}
