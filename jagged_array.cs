using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] scores = new int[][]
            {
                new int[] { 90, 80, 70 },
                new int[] { 60, 50 },
                new int[] { 30, 20, 10, 5 }
            };
            Console.WriteLine("Array Elements:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j < scores[i].Length; j++)
                {
                    Console.Write($"{scores[i][j]} ");
                }
                Console.WriteLine();
            }


            // Array properties
            Console.WriteLine($"Array Length: {scores.Length}");
       
        }
    }
}
