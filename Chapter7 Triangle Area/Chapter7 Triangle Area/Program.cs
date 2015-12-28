using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
        //The formula for the area of a triangle is A = .5 * base * height
        float b = 5;
        float h = 6;
        float area = .5f * b * h;

            Console.WriteLine("The area of a triangle is " + area + ".");

            var b_two = 1.5f;
            var h_two = 4f;
            var area_two = .5 * b_two * h_two;

            Console.WriteLine("The area of a triangle is " + area_two + ".");

        }
    }
}
