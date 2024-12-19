using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentage
{
    internal class Program
    {
        static void Main()
        {
            int i;
            Console.WriteLine("enter percentages");
            i = Convert.ToInt32(Console.ReadLine());
            if (i <= 35)
            {
                Console.WriteLine("fail");
            }
            else
            {
                if (i > 35 && i < 50)
                {
                    Console.WriteLine("third class");
                }
                else
                {
                    if (i > 50 && i < 60)
                    {
                        Console.WriteLine("second class");
                    }
                    else
                    {       
                    if (i > 60 && i < 80)
                            {
                                Console.WriteLine("first class");
                            }
                            else
                            {
                                if (i > 80 && i < 100)
                                {
                                    Console.WriteLine("distnict");
                                    Console.ReadLine();
                                }
                            }
                        }
                    }
                }
                }

            }
        }
    