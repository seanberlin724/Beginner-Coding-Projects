/******************Block Comment***********************
* Sean Berlin
* Create a console application called EX21_Operation. Write code that allows the user to enter an integer.
* Use this method twice to collect two integers, call it getInteger(string s). 
* getInteger(string s) should accept a string argument that will prompt the user with the appropriate question. 
* Next create two functions that manipulates the data collected. One for getDivision() and the other getModDivision().
* Finally a method that displays the results of integer(/) and modulus(%) division in either order. 
* You may want to use the Console.WriteLine formatting options for example:
* Console.WriteLine("{0} / {1} = {2}",firstInt, secondInt, getDivision(firstInt,secondInt));         
* Sample input and output:
* Enter first integer: 13
* Enter second integer: 4 
* Results:
* 13 / 4 = 3
* 13 % 4 = 1
* 4 / 13 = 0
* 4 % 13 = 4 
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Integer Calculations", "This program will show calculations ", ConsoleColor.Blue, 70);
            int x = getInteger();
            int y = getInteger();
            int prod = getDivision(x, y);


            int quotient = getModule(x, y);
            output(x, y);

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
        public static int getInteger()
        {
            Console.WriteLine("Enter an Integer");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;

        }
        public static int getDivision(int x, int y)
        {
            return x / y;
        }
        public static int getModule(int x, int y)
        {
            return x % y;
        }
        public static void output(int x, int y)
        {
            Console.WriteLine("Results:");
            Console.WriteLine("{0} / {1} = {2}", x, y, getDivision(x, y));
            Console.WriteLine("{0} % {1} = {2}", x, y, getModule(x, y));
            Console.WriteLine("{1} / {0} = {2}", x, y, getDivision(y, x));
            Console.WriteLine("{1} % {0} = {2}", x, y, getModule(y, x));
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

