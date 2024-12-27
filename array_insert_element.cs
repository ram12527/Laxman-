using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Display array elements using for loop
            Console.WriteLine("Array Elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }

            // Sum of array elements using for loop
            int sum = 0;
            Console.WriteLine("Sum of Array Elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum: {sum}");

            // Find maximum element using for loop
            int max = numbers[0];
            Console.WriteLine("Maximum Element:");
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Maximum Element: {max}");
        }
    }
}

        
