using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fizz Buzz! Multiple of 3, print Fizz. Multiple of 5, print Buzz. Multiple of both 3 and 5, print FizzBuzz

            for (int num = 1; num < 101; num++)
            {
                if (num % 5 == 0 && num % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }




        }
    }
}