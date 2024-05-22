/***************************************************
 * Sean Berlin
 * This is the demo for methods or sometimes called functions
 * Methods, arguments, return types
 * L3_IntroToMethods 
 ****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L3_IntroToMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro to the Program
            //this is where we describe what the program will do
            Intro("Chicken Monkey", "It calculates AREA!!!\nGiven the dimensions of a house\nit will calculate it's area.", ConsoleColor.Blue, 70);
            //Collect information from the user
            double length = getData("length:");
            double width = getData("width:");
            //double height = getData("height");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            //Do something with the data
            double area = getArea(length,width);

            //Display the Results
            Console.ForegroundColor = ConsoleColor.Yellow;
            displayResults(length, width, area);

            //Show a Cool and Proper ending
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
        public static double getData(string dimention)
        {
            Console.WriteLine("Please enter the " + dimention);
            double temp = Convert.ToDouble(Console.ReadLine());
            return temp;
        }
        public static double getArea(double l, double w)
        {
            double area = l * w;
            return area;
        }
        public static void displayResults(double length,double width,double area)
        {
            Console.WriteLine("The area of the house with dimentions \n{0:f2} by {1:f2} is {2:f2} square feet.", length, width, area);
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
