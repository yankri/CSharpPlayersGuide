using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("So you need to do some math, huh? \nEnter: \n+ for addition \n- for subtraction \n* for multiplication \n/ for division \n^ for exponentials");
            var menuChoice = Console.ReadLine();

            Console.WriteLine("Enter the first number you wish to use in your calculation. For exponents, x in x^y.");
            string firstInput = Console.ReadLine();
            double first = Convert.ToDouble(firstInput);

            Console.WriteLine("Enter the second number you wish to use in your calculation. For exponents, y in x^y.");
            string secondInput = Console.ReadLine();
            double second = Convert.ToDouble(secondInput);

            double result = 0.0;
            bool showResult = true;

            switch (menuChoice)
            {
                case "+":
                    Console.WriteLine("You want to add the numbers " + first + " and " + second + ".");
                    result = (first + second);
                    break;
                    
                case "-":
                    Console.WriteLine("You want to subtract the numbers " + first + " and " + second + ".");
                    result = (first - second);
                    break;

                case "*":
                    Console.WriteLine("You want to multiply the numbers " + first + " and " + second + ".");
                    result = (first * second);
                    break;

                case "/":
                    Console.WriteLine("You want to divide the numbers " + first + " and " + second + ".");
                    result = (first / second);
                    break;

                case "^":
                    Console.WriteLine("You want to multiply " + first + " by itself " + second + " times.");
                    result = Math.Pow(first, second);
                    break;

                default:
                    Console.WriteLine("Uh, did you enter an operator?");
                    showResult = false;
                    break;
            }

            if (showResult)
            {
                Console.WriteLine("The answer is " + result + ".");
            }
            
            Console.ReadKey();

            }


        }
    }

