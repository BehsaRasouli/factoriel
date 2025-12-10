using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static int facto(int n)
        {

            int mul = 1;
            for (int i = 1; i <= n; i++)
            {
                mul *= i;
            }
            return mul;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(facto(4));

        }
    }
}
