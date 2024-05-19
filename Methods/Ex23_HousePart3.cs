/******************Block Comment***********************
* Sean Berlin
* I know another HOUSE project!!!
*Design an application called EX23_HousePart3 using methods that will display
* the number of square feet in a house.
* In addition make a method that finds the number of square yards
* with the same measurements.
* Allow the user to enter values for the length and width of the house.
* Display the results in a pleasing manner. 
* Your program should use several methods including an Introduction(),
* CollectData(string word), CalculateArea(double l, double w), 
* SqFeetToSqYards(double feet), displayResults(double l, double w) and ending(). 
* You may use the methods from your other House project.
 *Example:
    Please enter the length of the house in feet: 45.25
    Please enter the width of the house in feet: 31.50
    The area of the house with dimensions 45.25’ 
    by 31.50’ is 1425.38 square feet. That is 158.375 
    square yards.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_HousePart3_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("House Measurement Converter", "This program will find the area of a house in square feet and square yards", ConsoleColor.Green, 70);
            double length = CollectDataLength();
            double width = CollectDataWidth();
            double area = CalculateArea(length, width);
            double CalcArea = SqFeetToSqYards(area);
            DisplayResults(length, width, area, CalcArea);
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
        public static double CollectDataLength()
        {
            Console.WriteLine("Please enter the length of the house in feet");
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public static double CollectDataWidth()
        {
            Console.WriteLine("Please enter the width of the house in feet");
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public static double SqFeetToSqYards(double area)
        {
            return area / 9;
        }
        public static void DisplayResults(double length, double width, double area, double CalcArea)
        {
            Console.WriteLine("The area of the house with dimensions {0}' by {1}'is {2} square feet.\nThat is {3} square yards", length, width, area, CalcArea);
        }
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();

        }
    }
}

