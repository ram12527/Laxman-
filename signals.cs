using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signals
{
    internal class Program
    {
        static void Main()
        {
            string signal;
            Console.WriteLine("enter the signal");
            signal = Console.ReadLine();
            if (signal == "red")
            {
                Console.WriteLine("stop");
            }
            else
            {
                if (signal == "green")
                {
                    Console.WriteLine("go");
                }
                else
                {
                    if (signal == "yellow")
                    {
                        Console.WriteLine("slow");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}  

