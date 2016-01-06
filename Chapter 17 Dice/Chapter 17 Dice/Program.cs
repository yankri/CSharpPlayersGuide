using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many dice do you wish to roll? Enter a \"quit\" to quit.");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    break;
                }

                int diceNumber = int.Parse(userInput);

                decimal total = 0;

                Random random = new Random(diceNumber);

                for (int i = 0; i < diceNumber; i++)
                {
                    decimal rolls = random.Next(6) + 1;
                    total += rolls;
                    Console.WriteLine("Roll: " + rolls);
                }

                Console.WriteLine("The total of your dice is: " + total);

            }

        }
    }
}
