using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    internal class table2
    {
        static void Main(string[] args)
        {
            int num = 2;
            Console.WriteLine("enter a number");
            for(int i= 2; i<=10;  i++)
            {
                Console.WriteLine($"{num}*{i}={num * i}");
                Console.ReadLine();
            }
        }
        

    }
}
