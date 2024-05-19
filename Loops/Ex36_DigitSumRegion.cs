/******************Block Comment***********************
 * Sean Berlin
 * Create a Console Application called Ex36_DigitCubeSumRegion.
 *  Modify looping Ex35_DigitCubeSum 
 *  to determine what integers of two, three, or four digits are equal to the sum of the cubes of their digits. 
 *  Hint: Creating a method will make this process much easier.  
 *  Note: Only a few numbers have these conditions. This program requires no input.
 *  When it is executed it should print only show a small list of numbers.
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_DigitCubeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Digit Cube Sum Region", "This program will find what integers of \ntwo,three,or four digits are equal to the sum \nof the cubes of their digits", ConsoleColor.Green, 72);
            int sumOfCubesDigitsFinder = sumOfCubesOfDigitsFinder();
            for ( i = 10; i < 1000; i++)
            {
                if (i == i )
                {
                    Console.WriteLine(+i);
                }                
            }
            ending();
        }
        public static int sumOfCubesOfDigitsFinder()
        {
            int num  9999;
            int sum = 0;
            int max = 100000;
            while (max > num)
            {
                max = max / 10;
            }
            while (max > 0)
            {
                int digitt = num / max;
                //cube = digitt * digitt * digitt;
                sum = sum + (digitt * digitt * digitt);
                num = num % max; //152
                max = max / 10;
            }
            return sum;
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
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();
        }
    }
}
