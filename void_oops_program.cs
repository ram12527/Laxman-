using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_oops_program
{
    class A
    {
        int a, b, c;
        public void Add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.a= 10;
            a1.b = 20;
           // Console.WriteLine("a1.a");
            A a2 = new A();
            a2.a = 40;
            a2.b = 50;
            a1.Add();
            a2.Add();

        }
    }
}
