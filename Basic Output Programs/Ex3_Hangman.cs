/******************Block Comment***********************
 * Sean Berlin         Per.9                 9-12-18
 * This is a program that shows the basics of
 * the c# program
 * Hangman is a favorite childhood game.
 * Design the stick figure for this game and produce your stickman in the console. 
 * One possible design.
 * Don’t forget the use of color.(Background and Foreground)
 * 
 * 
 * *****************************
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_[_]_ .,,");
            Console.WriteLine(" (\") ((\"))");
            Console.WriteLine("_/|\\ // \\\\/");
            Console.WriteLine("  : '/___\\");
            Console.WriteLine(" _|\\__/ |_");
            Console.ReadLine();
        }
    }
}
