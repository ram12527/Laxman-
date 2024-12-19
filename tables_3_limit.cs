using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    internal class table3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a limit");
            int limit = Convert.ToInt32(Console.ReadLine());          
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine($"{num}*{i}={num*i}");
                Console.ReadLine();
            }

        }
    }
}
