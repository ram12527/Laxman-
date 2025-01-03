using System;

// Static class for arithmetic operations
public static class ArithmeticOperations
{
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Divide(double num1, double num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}

// Normal class for calculator
public class Calculator
{
    private double[] numbers;

    public Calculator(double[] numbers)
    {
        this.numbers = numbers;
    }

    public double PerformOperation(string operation)
    {
        double result = 0;

        switch (operation)
        {
            case "+":
                result = ArithmeticOperations.Add(numbers[0], numbers[1]);
                break;
            case "-":
                result = ArithmeticOperations.Subtract(numbers[0], numbers[1]);
                break;
            case "*":
                result = ArithmeticOperations.Multiply(numbers[0], numbers[1]);
                break;
            case "/":
                result = ArithmeticOperations.Divide(numbers[0], numbers[1]);
                break;
            default:
                throw new ArgumentException("Invalid operation.");
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        double[] numbers = new double[] { num1, num2 };
        Calculator calculator = new Calculator(numbers);

        try
        {
            double result = calculator.PerformOperation(operation);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}