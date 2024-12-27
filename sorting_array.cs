using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, 9, 6, 5, 1 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", numbers));

            Array.Sort(numbers);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
