using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            var checkWork = b * quotient + remainder;

            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
            Console.WriteLine(a +  "/" + b + " is " + b + " remainder " + 1);
            Console.Write(checkWork + " should be the same as " + a);
        }
    }
}
