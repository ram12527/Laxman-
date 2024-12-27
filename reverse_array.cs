using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", numbers));

            Array.Reverse(numbers);

            Console.WriteLine("Reversed array:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
    }

