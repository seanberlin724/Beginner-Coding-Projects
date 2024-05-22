/******************Block Comment***********************
 * Sean Berlin
 * Create a Console Application called Ex35_DigitCubeSum. 
 * Write code to display the sum of the cubes of the digits of any non-negative integer. 
**********************************************
This program will display the sum of the cubes
of the digits of any positive integer you enter.
**********************************************
Enter an integer: 145
The sum of the cubes of the digits of 145 is 190.
Would you like to try another? n

Thank you for using this program.
Have a nice day.
 * 
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
            Intro("Digit Cube Sum","This program will collect a positive integer and find the sum of the cubes of its digits",ConsoleColor.Green,72);
            string tester = "no";
            do
            {
                Console.Write("Input any positive integer:");
                long num = Convert.ToInt64(Console.ReadLine());              
                long sum = 0;
                long max = 1000000000000000000;
                while (max > num)
                {
                    max = max / 10;
                }
                while (max > 0)
                {
                    long digitt = num / max;
                    //cube = digitt * digitt * digitt;                   
                    sum = sum + (digitt*digitt*digitt);                    
                    num = num % max; //152
                    max = max / 10;
                }
                Console.WriteLine("The cube is " + sum);
                Console.WriteLine("Would you like to try another? Yes or no");
                tester = Console.ReadLine();
            } while (tester.ToLower() == "yes");
            Console.WriteLine("Have a nice day");
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
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();
        }
    }
}
