using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Balls balley = new Balls(5.1, new Colors(34, 23, 45));

            for (int i = 0; i < 5; i++)
            {
                balley.Throw();
            }

            Console.WriteLine(balley.ThrowCount());

            Balls balley2 = new Balls(4, new Colors(24, 34, 12));

            balley2.Pop();

            Console.WriteLine(balley2.GetSize());

            balley2.Throw();

            Console.WriteLine(balley2.ThrowCount());
            

        
        }
    }
}
