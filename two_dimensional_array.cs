using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] scores = {
                {90, 80, 70},
                {60, 50, 40},
                {30, 20, 10}
            };
            Console.WriteLine("Array Elements:");
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    Console.WriteLine($"Row {i}, Column {j}: {scores[i, j]}");
                }
            }

            // Array properties
            Console.WriteLine($"Array Length: {scores.Length}");
            Console.WriteLine($"Array Rank: {scores.Rank}");
            Console.WriteLine($"Number of Rows: {scores.GetLength(0)}");
            Console.WriteLine($"Number of Columns: {scores.GetLength(1)}");
        }
    }
    }

