using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copying_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[] copiedArray = new int[originalArray.Length];

            Array.Copy(originalArray, copiedArray, originalArray.Length);

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", originalArray));

            Console.WriteLine("Copied array:");
            Console.WriteLine(string.Join(", ", copiedArray));
        }
    }
}
