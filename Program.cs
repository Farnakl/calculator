using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите математическую операцию");
            string operation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double second = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = Function.Plus(second, first);
                    break;
                case "-":
                    result = Function.Minus(second, first);
                    break;
                case "*":
                    result = Function.Multiplication(second, first);
                    break;
                case "/":
                    result = Function.Division(second, first);
                    break;
                default:
                    Console.WriteLine("Responce: 404");
                    break;
            }
            Console.WriteLine("Результат:" + " " + result);
            Console.ReadKey();
        }
    }
}
