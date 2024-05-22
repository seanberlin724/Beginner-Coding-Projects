/******************Block Comment***********************
 * Sean Berlin
 * Create the method called intro() so that the background color, console title are changed from the default. 
 * This method should also explain what the program is doing. 
 * Next create a method called ending() that has an appropriate ending like the one explained in class. 
 * Something like <-- hit enter to end -->. 
 * You may wish to save these methods in your toolbox.
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program that uses Intro and Ending", "This program can change background color \nand console title from default",ConsoleColor. Blue, 70 );
            Console.ReadKey();
            Console.Clear();
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
