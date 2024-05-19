/******************Block Comment***********************
 * Sean Berlin
 * Create a console called EX40_PrimeFactors. 
 *  Write code that displays the prime factors of an integer entered by the user. 
 *  If a number is prime factor more than once, it should be printed more than once.
 *  A console application output should look similar to:
 * Enter number:    140
 * The prime factors of 140 are: 2, 2, 5, 7
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX40_PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Prime Factor Finder", "This program will find the prime factors of a given number", ConsoleColor.Black, 80);
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime factors are ",num);
            for (int i = num; 2 <= num; i++)
            {
                for (i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        if (i < num)
                        {
                            Console.Write(i + ",");
                        }
                        else
                        {
                            Console.Write(i);
                        }
                        num = num / i;
                        i--;
                    }
                }
            }
            ending();
            Console.ReadLine();
        }
        public static void Intro(string title, string discription, ConsoleColor myColor, int myWidth)
        {
            Console.Title = title;
            Console.BackgroundColor = myColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = myWidth;
            Console.WindowHeight = 15;
            Console.Clear();
            Console.WriteLine("This is the Greatest Into ever!!");
            Console.WriteLine(discription);
        }
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();
        }
    }
}
    
