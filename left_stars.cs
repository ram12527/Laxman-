using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace left_star_using_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    Console.Write("");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
