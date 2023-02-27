using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAk
{
    public class Function
    {
        public static double Plus(double second, double first)
        {
            double result = first + second;
            return result;
        }
        public static double Minus(double second, double first)
        {
            double result = first - second;
            return result;
        }
        public static double Multiplication(double second, double first)
        {
            double result = first * second;
            return result;
        }
        public static double Division(double second, double first)
        {
            double result = first / second;
            return result;
        }
    }
}
