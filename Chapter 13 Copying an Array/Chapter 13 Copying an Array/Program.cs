using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13_Copying_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write code to copy an array

            int[] numbers = new int[10] { 4, -4, 8, 15, 27, 30, -15, -34, 44, 47 };

            int[] newArray = new int[numbers.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                newArray[index] = numbers[index];
            }

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write(numbers[index] + " ");
            }

            Console.WriteLine();

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write(newArray[index] + " ");
            }

            Console.WriteLine();
        }
    }
}
