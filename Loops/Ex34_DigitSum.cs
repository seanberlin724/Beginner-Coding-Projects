/******************Block Comment***********************
 * Sean Berlin
 * Create a Console Application called Ex34_DigitSum.
 *  Write code that displays the sum of the digits of any non-negative integer. 
 *  Use a while loop to ask the user to continue with another. 
 *  Example of the output:
**********************************************
This program will display the sum of the digits
of any positive integer you enter.
**********************************************
Enter an integer: 145
The sum of the digits of 145 is 10.
Would you like to try another? Y
Enter an integer: 8888
The sum of the digits of 8888 is 32.
Would you like to try another? N
Thank you for using this program.
Have a nice day.
* *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex34_DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Digits Program", "This program wil  display the sum of any positive integer's digits", ConsoleColor.Green, 72);
            //Console.Write("Input any positive integer:");
            //long num = Convert.ToInt64(Console.ReadLine());
            //// long sum = 0;
            //long max = 1000000000000000000;
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
                    sum = sum + digitt;
                    num = num % max; //152
                    max = max / 10;
                }
                Console.WriteLine("The sum is " + sum);
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
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();
        }
    }
}


