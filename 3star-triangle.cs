using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_3_star_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i < rows; i++) 
            {
                for (int j = 0; j < rows - i-1; j++)
                    Console.WriteLine( "");
                for(int k=0;k<i;k++)
                
          
                
                    Console.Write("*");
                    Console.WriteLine();
                

            }
        }
    }
}
