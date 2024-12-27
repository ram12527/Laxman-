using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace total_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int total = 0;
            int[] n = new int[5];
            for (i = 0; i < 5; i++)
            {
                n[i] = i + 5;



            }
            for (i = 0; i < 5; i++)
            {
                total += n[i];
                Console.WriteLine("value[{0}]= {1}", i, n[i]);


            }
            Console.WriteLine("The Total is:  " + total);
            Console.ReadLine();
        }
    }
    }

