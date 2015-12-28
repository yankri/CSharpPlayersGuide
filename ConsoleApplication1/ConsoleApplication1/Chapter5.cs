using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            score = 0;

            int a = 5;
            int b = 2;

            b = a;
            a = -3;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
