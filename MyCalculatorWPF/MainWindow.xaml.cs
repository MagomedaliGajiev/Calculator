using ClassLibraryCalculator;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyCalculatorWPF
{
    public partial class MainWindow : Window
    {
        Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            calculator.ResultGet += Calculator_ResultGet;
        }

        private void Calculator_ResultGet(object? sender, CalculatorArgs e)
        {
            Answer.Content = e.answer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var parse = int.TryParse(InputText.Text, out int value);
            var name = (e.Source as FrameworkElement).Name;

            if (!parse)
            {
                MessageBox.Show("Неверно ввели данные!");
                InputText.Text = string.Empty;
            }
            switch (name)
            {
                case "Add": calculator.Add(value); break;
                case "Sub": calculator.Sub(value); break;
                case "Mult": calculator.Mult(value); break;
                case "Div": calculator.Div(value); break;
                default:
                    MessageBox.Show("Ошибка нажатия кнапки");
                    InputText.Text = string.Empty; break;
            }
        }
    }
}