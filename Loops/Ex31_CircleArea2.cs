/******************Block Comment***********************
 * Sean Berlin
* Create a Console Application called Ex31_CircleArea2. 
* Yet another Circle program. This time modify it to include a while loop so that many circle areas can be computed again. 
* This time let the radius of zero indicate the end of the input. The output should look something like this.
* *******************************
* Welcome to the Circle AREA calculator.
* *******************************
* What is the radius of your circle?(0 to quit) 10
* The area of the circle with radius 10 is 
* 314.15 square units. 
* *******************************
* What is the radius of your circle?(0 to quit) 12
* The area of the circle with radius 12 is 
* 452.38 square units.
* ******************************* 
* What is the radius of your circle?(0 to quit) 0
* Thank you for using the Circle Area calculator.
* Have a nice day.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_CircleArea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Circle Area calculator", "This program will calculate the area of a circle with given radius", ConsoleColor.Green, 72);
            Console.WriteLine("***************************");
            Console.WriteLine("What is the radius of your circle?(0 to quit)");
            Console.WriteLine();
            double radius = 6;
            while (radius > 0)
            {
                radius = RadiusCollector();
                if (radius > 0)
                {
                    double area = areaCalculator(radius);
                    Console.WriteLine("The area of the circle is " + area);
                    Console.WriteLine("**************************");
                }
            }
            Console.WriteLine("Thank you for using Circle area calculator \nHave a nice day");
            ending();
        }
        public static void Intro(string title, string discription, ConsoleColor myColor, int myWidth)
        {
            Console.Title = title;
            Console.BackgroundColor = myColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = myWidth;
            Console.WindowHeight = 15;
            Console.Clear();
            Console.WriteLine("This is the Greatest Into ever!!");
            Console.WriteLine(discription);
        }
        public static double RadiusCollector()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public static double areaCalculator(double radius)
        {
            return radius * radius * Math.PI;
        }
        public static void displayData(double radius, double area)
        {
            Console.WriteLine("The area of a circle with radius {0} is \n {1} square units", radius, area);
        }
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();
        }
    }
}

