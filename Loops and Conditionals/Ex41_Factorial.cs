/******************Block Comment***********************
 * Sean Berlin
 * Create a console or windows application called EX41_Factorial.
 * The factorial of a positive number is the product of 
 * all positive integers less than or equal to the number.  
 * For example, 5 factorial (written 5!) is equal to 5*4*3*2*1, or 120.
 * Write code that reads a positive integer and displays its factorial.
 * The program should calculate the answer by using loops of some kind.  
 * Negative factorials are considered to be undefined.  
 * This program should check for undefined factorial and display the appropriate message. 
 * The console program output should look similar to:
 * Enter an integer(-999 to quit): 5
				5! = 120

				Enter an integer(-999 to quit): -4
				-4! is undefined  try again

				Enter an integer(-999 to quit):  0
				0! = 1

				Enter an integer(-999 to quit):  -999
				Thank you have a nice day.
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX41_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Factorial Finder", "This program will find the factorial of a given number", ConsoleColor.White, 80);
            int num = 0;
            do
            {
                Console.WriteLine("Enter an integer (-999 to quit):");
                num = numCollector();
                int counter = 1;
                int fact = 1;
                if (num < 0)
                {
                    Console.WriteLine("Undefined. Pleas enter a non negative number");
                }
                else
                {
                    for (counter = num; counter >= 1; counter--)
                    {
                        fact = fact * counter;
                    }
                    Console.WriteLine("The factorial of {0} is {1}", num, fact);
                }
            } while (num >= -998);
            Console.WriteLine("Thank you, have a nice day.");
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
        public static int numCollector()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
    }
}


