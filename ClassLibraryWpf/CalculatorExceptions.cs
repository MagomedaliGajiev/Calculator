using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibraryWpf
{
    public class CalculatorExceptions : CalculatorArithmetic
    {
        public override void Add(double value)
        {
            try
            {
                base.Add(value);
            }
            catch (Exception  e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Substract(double value)
        {
            try
            {
                base.Substract(value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Multiply(double value)
        {
            try
            {
                base.Multiply(value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void Divide(double value)
        {
            try
            {
                base.Divide(value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Cancel()
        {
            try
            {   
                base.Cancel();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
}
