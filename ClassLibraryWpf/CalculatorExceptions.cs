using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibraryWpf
{
    public class CalculatorExceptions : Calculator
    {
        public override void Div(int value)
        {
            try
            {
                base.Div(value);
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
