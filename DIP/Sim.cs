namespace DIP
{
    class Sim
    {
        public const string number = "(000) 12-34-56";

        // instead of Viva viva, Beeline beeline or Ucom ucom;
        public IMobileOperator mobileOperator; 

        public Sim(IMobileOperator mobileOperator)
        {
            this.mobileOperator = mobileOperator;
        }

        public string ShowOperatorName()
        {
            return this.mobileOperator.GetOperator(number);
        }
    }
}
