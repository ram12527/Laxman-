using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int  multiplier  = 1;
            Console.WriteLine($"multiplication table for {num}:");
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine($"{num}*{i}={num * i}");
                Console.ReadLine();
            }
            }
    }
}

