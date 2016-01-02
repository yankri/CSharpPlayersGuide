using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12_Take_2
{
    class Program
    {
        static void Main(string[] args)
        {           

            //Prints out a pyramid of asterisks
            for (int row = 1; row < 6; row++)
            {
                for (int space = 5-row; space > 0; space--)
                {
                    Console.Write("-"); //added dashes to make spaces visible
                }
                for (int column = 1; column < row * 2; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}
