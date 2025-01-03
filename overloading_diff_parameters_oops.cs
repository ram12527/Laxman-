using System;

public class Calculator
{
    // Method with no parameters
    public void Calculate()
    {
        Console.WriteLine("No parameters provided.");
    }

    // Method with one parameter
    public void Calculate(int num1)
    {
        Console.WriteLine($"Result: {num1 * num1}");
    }

    // Method with two parameters
    public void Calculate(int num1, int num2)
    {
        Console.WriteLine($"Result: {num1 + num2}");
    }

    // Method with two parameters of different types
    public void Calculate(int num1, string operation)
    {
        Console.WriteLine($"Performing {operation} operation on {num1}.");
    }

    // Method with three parameters
    public void Calculate(int num1, int num2, int num3)
    {
        Console.WriteLine($"Result: {num1 + num2 + num3}");
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        // Call method with no parameters
        calculator.Calculate();

        // Call method with one parameter
        calculator.Calculate(5);

        // Call method with two parameters
        calculator.Calculate(5, 10);

        // Call method with two parameters of different types
        calculator.Calculate(5, "multiplication");

        // Call method with three parameters
        calculator.Calculate(5, 10, 15);
    }
}