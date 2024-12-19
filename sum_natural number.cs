using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_natural_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("natural number");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"{n}:{sum}");

            }
        }
    }

