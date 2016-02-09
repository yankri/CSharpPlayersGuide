using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Chapter_15_Fibonacci
{
    class Program
    {
        static int F(int number )
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(F(number));
        }

        static int F(int number, int a = 1, int b = 1, int counter = 1)
        {
            //Establish the base case
            if(number == 1)
            {
                return 1; //Need return here because you don't want to run the rest of the code if the answer is one. 
            }
            if (counter < number)
            {
                return F(number, b, a + b, counter + 1); //counter+1 is the increment
            }
            else //else is always the last function call in the sequence, the end of the recursion (in nesting doll analogy, the last doll you said it could use)
            {
                return a; //Returns the last number in the sequence when counter is less than number
            }
        }
    }
}
