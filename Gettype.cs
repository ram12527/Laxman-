using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_program
{
    internal class Program
    {
        static void Main(string[] args)
            {
                int a = 10;
                Console.WriteLine(a);
                float f = 12.5f;
                Console.WriteLine(f.GetType());
                bool d = true;
                Console.WriteLine(d.GetType());
                char c = 'a';
                Console.WriteLine(c.GetType());
                string s = "ram";
                Console.WriteLine(s.GetType());
                Console.ReadKey();
            }
    }
}
