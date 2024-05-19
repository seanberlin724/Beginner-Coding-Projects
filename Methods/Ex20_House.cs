 /******************Block Comment***********************
* Sean Berlin
* Write a program that asks the user for the dimensions of a house.
* Then find the square footage of the house and display it.
* Remember to include an intro and ending method.
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_House
{
    class Program
    {
        static void Main(string[] args)
        {

            intro("House Program to Find Dimensions", ConsoleColor.Blue, 70, "Input the dimensions of the house to find the total area. ");

            int temp = saying();
            int temp2 = saying();
            int prod = findProduct(temp, temp2);
            output(prod);
            ending();
        }
        public static void intro(string title, ConsoleColor myColor, int myWidth, string description)
        {

            Console.Title = title;
            Console.BackgroundColor = myColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = myWidth;
            Console.WindowHeight = 15;
            Console.Clear();
            Console.WriteLine(description);

        }
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();

        }
        public static int saying()
        {
            Console.Write("Please enter a Dimension:");
            int temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }
        public static int findProduct(int x, int y)
        {
            return x * y;
        }

        public static void output(int x)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("**  " + x + "sq ft" + "     **");
            Console.WriteLine("*******************");
            Console.ReadLine();
        }
    }
}

