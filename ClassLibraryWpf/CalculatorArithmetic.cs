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
        public double Result { get; private set; } = 0;
        Stack<double> results = new Stack<double>();

        protected virtual void GetCalculation()
        {
            ResultGet?.Invoke(this, new CalculatorArgs { Answer = Result });
        }

        public virtual void Add(double value)
        {
            results.Push(Result);
            Result += value;
            GetCalculation();
        }

        public virtual void Substract(double value)
        {
            results.Push(Result);
            Result -= value;
            GetCalculation();
        }

        public virtual void Multiply(double value)
        {
            results.Push(Result);
            Result *= value;
            GetCalculation();
        }

        public virtual void Divide(double value)
        {
            results.Push(Result);
            Result /= value;
            GetCalculation();
        }

        public virtual void Cancel()
        {
            if (results.Count > 0)
            {
                Result = results.Pop();
                GetCalculation();
            }
        }
    }
}

