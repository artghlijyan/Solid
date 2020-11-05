namespace DIP
{
    class Beeline : IMobileOperator
    {
        const string operatorName = "Beeline";

        public string GetOperator(string number)
        {
            return $"{number} is {operatorName} Phone number";
        }
    }
}
