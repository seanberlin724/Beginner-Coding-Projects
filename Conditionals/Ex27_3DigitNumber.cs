/*****************Block Comment***********************
 * Sean Berlin
 * (2 Days)Write a program called EX27_3DigitNumber. 
 * Make the console application so that it accepts a three digit number and displays the digits each on a single line.
 *  Then, calculate and display the sum of the digits and determine if the sum is odd or even.
 *   Hint….you’ll have to use the modulus (%) operator to find the ones, 
 * tens and hundreds digits for this exercise. NO STRING 
 * METHODS! The program output should look similar to:
 * Example of what your code should look like:
 * Enter a three-digit number: 274
 * The first digit is: 2
 * The second digit is: 7
 * The third digit is: 4
 * The sum of the digits is 13.
 * The number 13 is an odd number.
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27_3DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("3 Digit Sum Calculator","This program will calculate the sum of three digits\nand tell if it is even or odd",ConsoleColor.Green,72);
            int threeDigitNumber = threeDigitNumberCollector();
            int firstDigit = firstDigitFinder(threeDigitNumber);
            int secondDigit = secondDigitFinder(threeDigitNumber);
            int thirdDigit = thirdDigitFinder(threeDigitNumber);
            int threeDigitSum = threeDigitSumCalculator(firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("The first digit is: {0}",firstDigit);
            Console.WriteLine("The secound digit is: {0}", secondDigit);
            Console.WriteLine("The third digit is: {0}", thirdDigit);
            Console.WriteLine("The sum of the digits is:{0}",threeDigitSum);
            if (threeDigitSum % 2 == 1)
            {
                Console.WriteLine("The number {0} is an odd number",threeDigitSum);
                Console.ReadLine();
            }
            else
            if (threeDigitSum % 2 == 0)
            {
                Console.WriteLine("The number {0} is an even number",threeDigitSum);
                Console.ReadLine();
            }
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
        public static int threeDigitNumberCollector()
        {
            Console.Write("Enter a three-digit number:");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int firstDigitFinder(int threeDigitNumber)
        {
            return threeDigitNumber / 100;
        }
        public static int secondDigitFinder(int threeDigitNumber)
        {
            return threeDigitNumber % 100 / 10;
        }
        public static int thirdDigitFinder(int threeDigitNumber)
        {
            return threeDigitNumber % 100 % 10 / 1;
        }
        public static int threeDigitSumCalculator (int firstDigit, int secondDigit, int thirdDigit)
        {
            return firstDigit + secondDigit + thirdDigit;
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
