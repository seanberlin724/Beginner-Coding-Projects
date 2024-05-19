/******************Block Comment***********************
 * Sean Berlin
 * Create a Console Application called Ex30_CircleArea. 
 * Write code to calculate the AREA of a Circle, use methods for an introduction, calculation and display. 
 * Use a while statement to have the main body of the code repeat the calculation only if the user enters a Y or y to continue.
Output should look like this:
*******************************
Welcome to the Circle AREA calculator.
*******************************
Would you like to find the area of a circle? Y
Ok. What is the radius of your circle? 10
The area of the circle with radius 10 is 
314.15 square units. 
*******************************
Would you like to find the area of a circle? y
Ok. What is the radius of your circle? 12
The area of the circle with radius 12 is 
452.38 square units.
******************************* 
Would you like to find the area of a circle? n
Thank you for using the Circle Area calculator.
Have a nice day.
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Area Caclulator", "This program will caclulate the area of a circle", ConsoleColor.Green, 72);
           Console.WriteLine("Do you want to find the area of a circle");
            string tester = Console.ReadLine();
            while (tester.ToLower() == "yes") 
            { 
                double radius = radiusCollector();
                double area = areaCalculator(radius);
                displayData(radius, area);
                Console.WriteLine("Do you want to run this program again");
                tester = Console.ReadLine();
            }
            Console.WriteLine("Thank you for using the Circle Area calculator.\nHave a nice day.");
            Console.ReadLine();          
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
        public static double radiusCollector()
        {
            Console.WriteLine("Ok. What is the radius of your circle?");
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public static double areaCalculator(double radius)
        {
            return radius * radius * Math.PI;
        }
        public static void displayData(double radius, double area)
        {
            Console.WriteLine("The area of a circle with radius {0} is \n {1} square units",radius,area);
        }
    }
}
