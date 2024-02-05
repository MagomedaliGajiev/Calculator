using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWpf
{
    public class CalculatorArithmetic
    {
        public event EventHandler<CalculatorArgs> ResultGet;
        public int Result { get; private set; } = 0;
        Stack<int> results = new Stack<int>();

        protected virtual void GetCalculation()
        {
            ResultGet.Invoke(this, new CalculatorArgs { answer = Result });
        }

        public virtual void Add(int value)
        {
            results.Push(Result);
            Result += value;
            GetCalculation();
        }

        public virtual void Sub(int value)
        {
            results.Push(Result);
            Result -= value; ;
            GetCalculation();
        }

        public virtual void Mult(int value)
        {
            results.Push(Result);
            Result *= value;
            GetCalculation();
        }

        public virtual void Div(int value)
        {
            results.Push(Result);
            Result /= value;
            GetCalculation();
        }

        public virtual  void Cancel()
        {
            if (results.Count > 0)
            {
                Result = results.Pop();
                GetCalculation();
            }
        }
    }
}
