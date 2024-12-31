using System;

namespace OOPAddition
{
    // Main program to demonstrate usage
    class Program
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

        // Method to perform addition
        public int Add()
        {
            return _a + _b;
        }
    }
        static void Main(string[] args)
        {
            // Create an object of Calculator and pass values
            Calculator calc = new Calculator(30, 20);

            // Perform addition and display the result
            int result = calc.Add();
            Console.WriteLine($"The sum of 30 and 20 is: {result}");
        }
    }
}