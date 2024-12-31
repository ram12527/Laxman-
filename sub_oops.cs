using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addin_c_
{
    internal class program
    {
        // Class representing a calculator (Encapsulation)
        public class Calculator
        {
            // Private fields
            int _a;
            int _b;

            // Constructor to initialize values (Encapsulation)
            public Calculator(int a, int b)
            {
                _a = a;
                _b = b;
            }

            // Method to perform substraction
            public int Sub()
            {
                return _a - _b;
            }
        }
            static void Main()
            {
                Calculator calc = new Calculator(30, 20);
                int result = calc.Sub();
                Console.WriteLine($"The sum of 30 and 20 is: {result}");
            }
        }
    }

