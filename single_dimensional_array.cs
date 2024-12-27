using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 90, 80, 70, 60, 50 };
            Console.WriteLine("Array Elements:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"Index {i}: {Array[i]}");
            }
           
            Console.WriteLine($"Modified Element: {Array[0]}");
            Console.WriteLine($"Array Length: {Array.Length}");
            Console.WriteLine($"Array Rank: {Array.Rank}");
        }
    }
}
    
        
        
    

