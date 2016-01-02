using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10_Positive_or_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You will be asked to enter two numbers. \nThey can be positive or negative. \nThis program will determine if their product is positive or negative.");

            Console.WriteLine("Please enter the first number."); //First number input, converting to a double to handle decimals too. 
            string userInput1 = Console.ReadLine();
            double first = Convert.ToDouble(userInput1);

            Console.WriteLine("Please enter the second number."); //Second number input. 
            string userInput2 = Console.ReadLine();
            double second = Convert.ToDouble(userInput2);

            if (first == 0 || second == 0)   //If either number is 0, the answer will be zero, so I checked for that first. 
            {
                Console.WriteLine("Your answer will be zero.");
            }

            else
            {
                if ( (first < 0 && second < 0) || (first > 0 && second > 0) )  //Checking to see if the answer will be positive first. First part checks for two negative numbers, second checks for 2 positive numbers. Either result would be positive.
                {
                    Console.WriteLine("Your answer will be positive.");
                }
                else
                {
                    Console.WriteLine("Your answer will be negative."); // If one of the numbers is negative and the other is not, it will be negative. 
                }
            }

            Console.ReadKey();

        }
    }
}
