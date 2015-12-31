using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number. Convert the number to an integer.
            Console.WriteLine("Please enter an integer. This program will determine if it's even or odd.");
            string userNumberInput = Console.ReadLine();
            int userNumberQuery = Convert.ToInt32(userNumberInput); // Initiall

            if (userNumberQuery == 0)
            {
                Console.WriteLine("You entered zero!");
                // Zero is neither even nor odd, so I added a check for that. 
            }
            else
            {
                if (userNumberQuery % 2 == 0) //Checks for even. Even numbers will have no remainder.
                {
                    Console.WriteLine("Your number is even!");
                }
                else //Odd numbers will have a remainder. 
                {
                    Console.WriteLine("Your number is odd!");                        
                }
            }

            Console.ReadKey();

        }
    }
}
