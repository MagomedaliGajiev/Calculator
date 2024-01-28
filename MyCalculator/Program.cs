using ClassLibraryCalculator;

namespace MyCalculator

{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.ResultGet += Calculator_ResultGet;

            calculator.Add(10);
            calculator.Add(35);
            calculator.Div(3);
            calculator.Mult(2);

            Console.WriteLine();

            calculator.Cancel();
            calculator.Cancel();
            calculator.Cancel();
            calculator.Cancel();
            calculator.Cancel();

            calculator.ResultGet -= Calculator_ResultGet;

        }

        private static void Calculator_ResultGet(object? sender, CalculatorArgs e)
        {
            Console.Write($"{e.answer}  ");
        }
    }
}