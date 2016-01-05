using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14_Months_Enumeration
{
    public enum Months { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September =9,
                        October = 10, November = 11, December = 12};
    class Program
    {
        static void Main(string[] args)
        {
            //User enters a number to have the computer print out the name of the Month

            Console.WriteLine("Please enter a number between 1 and 12 to get the name of the month that corresponds with that number.");
            string userInput = Console.ReadLine();
            int request = Convert.ToInt32 (userInput);

            if (request > 0 && request < 13)
            {
                switch (request)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;

                    case 2:
                        Console.WriteLine("February");
                        break;

                    case 3:
                        Console.WriteLine("March");
                        break;

                    case 4:
                        Console.WriteLine("April");
                        break;

                    case 5:
                        Console.WriteLine("May");
                        break;

                    case 6:
                        Console.WriteLine("June");
                        break;

                    case 7:
                        Console.WriteLine("July");
                        break;

                    case 8:
                        Console.WriteLine("August");
                        break;

                    case 9:
                        Console.WriteLine("September");
                        break;

                    case 10:
                        Console.WriteLine("October");
                        break;

                    case 11:
                        Console.WriteLine("November");
                        break;

                    case 12:
                        Console.WriteLine("December");
                        break;

                    default:
                        Console.WriteLine("Did you enter a number between 1 and 12?");
                        break;
                   
                }
            }

            else
            {
                Console.WriteLine("Did you enter a number between 1 and 12?");
            }
        }
    }
}
