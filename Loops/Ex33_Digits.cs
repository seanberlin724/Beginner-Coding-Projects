/******************Block Comment***********************
 * Sean Berlin
 * “This one will take some time.” 
 * Create a Console Application called Ex33_Digits. 
 * Write code that takes a non-negative long as input and displays each of the digits on a separate line. 
 * Note you do not know how many digits the integer has. 
 * (You may not use string methods for the following few assignments, you must use mod%) 
 * Output should look like this: 
**********************************************
* This program will take your number and display 
* each of the digits on a separate line.
**********************************************
* Enter an integer: 71345
* 7
* 1
* 3
* 4
* 5
* Thank you.
* Have a nice day.	
 * ******************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Digits Program","This program wil  take any positive integer and display its digits",ConsoleColor.Green,72);
            Console.Write("Input any positive integer:");
            long  num = Convert.ToInt64(Console.ReadLine());
            long max = 1000000000000000000;
            while (max > num)
            {
                max = max / 10;
            }
            // num=85748
            // max= 10000
            while (max > 0)
            {
                long digitt = num / max;
                Console.WriteLine(+digitt);
                num = num % max; //152
                max = max / 10;
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
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();
        }
    }
}
