/******************Block Comment***********************
 * Sean Berlin
 * Create a program that uses the intro() method. 
 * Included in the program should be an additional method called saying(). 
 * Collect user input for a single factor of a multiplication problem.
 * Call this method twice and store both arguments as variables.
 * Send both arguments to a method to calculate the product.
 * Call another method called output() to diplay the answer and have it surrounded by two lines of asterisks. 
 * Finally use your ending() method to finish the project.
********************************************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18.output
{
    class Program
    {
        static void Main(string[] args)
        {//
           // enter two integers
          // find product of those ints

          intro("ex18.output", ConsoleColor.DarkCyan, 55, "Input two integers to find the product!!");
            
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
            Console.Write("Please enter an integer that you would like to multiply:");
            int temp = Convert.ToInt32( Console.ReadLine());
            return temp;
        }



        public static int findProduct(int x, int  y)
        {
            return  x*y;
        }

        public static void output(int x)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("**     "+ x + "     **");
            Console.WriteLine("*******************");
            Console.ReadLine();
        }
    }
}
