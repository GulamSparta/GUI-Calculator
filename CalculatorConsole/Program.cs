using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculator
    {
        public double Divide(double num1, double num2)
        {
            //double result = num1 / num2;
            return num1 / num2;
        }

        public double Add(double Addnum1, double Addnum2)
        {
            double result = Addnum1 + Addnum2;
            return result;
        }

        public double Subtract(double Subtractnum1, double Subtractnum2)
        {
            double result = Subtractnum1 - Subtractnum2;
            return result;
        }

        public double Multiply(double Multiplynum1, double Multiplynum2)
        {
            double result = Multiplynum1 - Multiplynum2;
            return result;
        }
    }
}
