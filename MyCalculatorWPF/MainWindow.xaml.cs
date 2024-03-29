﻿using ClassLibraryWpf;
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
            Answer.Content = e.Answer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var parse = int.TryParse(InputText.Text, out int value);
            var name = (e.Source as FrameworkElement).Name;

            if (!parse && InputText.Text != string.Empty)
            {
                MessageBox.Show("Неверно ввели данные!");
                InputText.Text = "0";
            }
            switch (name)
            {
                case "Add": calculator.Add(value); break;
                case "Sub": calculator.Substract(value); break;
                case "Mult": calculator.Multiply(value); break;
                case "Div": calculator.Divide(value); break;
                case "Cancel": calculator.Cancel(); break;
                default:
                    MessageBox.Show("Ошибка нажатия кнопки");
                    InputText.Text = string.Empty; break;
            }
            if (InputText.Text == string.Empty && name != "Cancel")
            {
                MessageBox.Show("Вы ввели пустую строку, поэтому программа закрывается!");
                Close();
            }
        }
    }
}