namespace ClassLibraryCalculator
{
    public class Calculator
    {
        public event EventHandler<CalculatorArgs> ResultGet;
        public int Result { get; private set; } = 0;
        Stack<int> results = new Stack<int>();

        private void GetCalculation()
        {
            ResultGet.Invoke(this, new CalculatorArgs { answer = Result});
        }

        public void Add(int value)
        {
            results.Push(Result);
            Result += value;
            GetCalculation();
        }

        public void Sub(int value)
        {
            results.Push(Result);
            Result -= value;;
            GetCalculation();
        }

        public void Mult(int value)
        {
            results.Push(Result);
            Result *= value;
            GetCalculation();
        }

        public void Div(int value)
        {
            results.Push(Result);
            Result /= value;
            GetCalculation();
        }

        public void Cancel()
        {
            if (results.Count > 0)
            {
                Result = results.Pop();
                GetCalculation();
            }
        }
    }
}
