using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13_averaging_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Totaling and averaging arrays

            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int total = 0;

            foreach (int number in array)
            {
                total += number;
            }

            float average = (float)total / array.Length;

            Console.WriteLine("The total is " + total);
            Console.WriteLine("The average is " + average);
        }
    }
}
