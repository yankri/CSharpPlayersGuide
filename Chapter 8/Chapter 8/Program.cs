using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //The formula for the volume of a cylinder is V = pi * r^2 * h
            //The formula for the surface area of a cylinder is SA = 2*pi*r(r+h)

            // Greeting message
            Console.WriteLine("Hi there! Let's calculate some values for a cylinder!");

            //Get the user's input for the radius, then convert that string to a double to use later. 
            Console.WriteLine("Please enter the value for the radius of the cylinder: ");
            string userRadiusInput = Console.ReadLine();
            double radius = Convert.ToDouble(userRadiusInput);

            //Get the user's input for  the height and then convert that string to a double to use later.
            Console.WriteLine("Please enter the value for the height of the cylinder; ");
            string userHeightInput = Console.ReadLine();
            double height = Convert.ToDouble(userHeightInput);

            //Make pi a variable so it's easier to use later
            double pi = 3.141592654;

            //The equations for calculating the volume and surface area of cylinders
            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            //Print out the values for the user for the volume and surface area using the user's inputs to calculate them. 
            Console.WriteLine("The cylinder's volume is: " + volume + " cubic units.");
            Console.WriteLine("The cylinder's surface area is: " + surfaceArea + " square units.");

            //Makes the program wait before closing. 
            Console.ReadKey();
     
        }
    }
}
