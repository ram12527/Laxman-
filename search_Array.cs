using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the number to search:");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    found = true;
                    Console.WriteLine($"{searchNumber} is present in the array at index {i}.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{searchNumber} is not present in the array.");
            }
        }
    }
}
    
