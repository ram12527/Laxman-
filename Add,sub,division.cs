using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_sub_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine(  "enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(  "enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
