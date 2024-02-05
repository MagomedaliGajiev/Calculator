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
        public override void Add(int value)
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

        public override void Sub(int value)
        {
            try
            {
                base.Sub(value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Mult(int value)
        {
            try
            {
                base.Mult(value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void Div(int value)
        {
            try
            {
                base.Div(value);
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
