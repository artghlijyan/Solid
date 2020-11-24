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
