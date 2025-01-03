using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_basic_oops
{
    class staticvar
    {
        public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class staticTester
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                staticvar s1 = new staticvar();
                staticvar s2 = new staticvar();

                s1.count();
                s1.count();
                s1.count();

                s2.count();
                s2.count();
                s2.count();
                s2.count();
                Console.WriteLine("variable num for s1: (0)", s1.getNum());
                Console.WriteLine("variable num for s2: (0)", s2.getNum());
                Console.ReadKey();
            }
        }
    }
}
