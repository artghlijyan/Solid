namespace DIP
{
    class VivaCellMts : IMobileOperator
    {
        const string operatorName = "VivaCell-MTS";

        public string GetOperator(string number)
        {
            return $"{number} is {operatorName} Phone number";
        }
    }
}
