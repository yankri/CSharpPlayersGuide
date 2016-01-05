using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15_Reversing_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for the array size.
            Console.WriteLine("Enter a positive integer to determine the size of the array.");
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);

            int[] numbers = GenerateNumbers(x);
            Reverse(numbers);
            PrintNumbers(numbers);


            
        }

        static int [] GenerateNumbers(int arraySize) //Uses a for loop to generate the numbers in the array. arraySize lets the user put in their own value for the array size. 
        {
            int[] newArray = new int[arraySize];

            for (int num = 0; num < arraySize; num++)
            {
                newArray[num] = num + 1;
            }
            return newArray;
        }

        //Reverses the array.  Puts the array values into a temporary variable to make the swap
        static void Reverse(int [] toReverse)
        {
            for (int index = 0; index < toReverse.Length/2; index++) //Only have to go halfway to make the swaps
            {
                int temp = toReverse[index];
                toReverse[index] = toReverse[toReverse.Length - index - 1]; //.Length - index - 1 accounts for the indexing starting at 0
                toReverse[toReverse.Length - index - 1] = temp;
            }
        }

        static void PrintNumbers (int [] numbersToPrint) //Prints out the values in the array plus a space to make them readable
        {
            foreach (int num in numbersToPrint)
                Console.Write(num + " ");
        }

    }
}
