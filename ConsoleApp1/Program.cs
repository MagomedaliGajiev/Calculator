using ClassLibraryCalculator;

namespace MyCalc

{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.Add(10);
            calculator.Add(20);
            calculator.Div(3);

            Console.WriteLine(calculator.Result);
        }
    }
}