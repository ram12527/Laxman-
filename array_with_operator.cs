using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_with_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /):");
            char op = Console.ReadLine()[0];

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}



        
