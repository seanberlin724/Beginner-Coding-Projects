 /******************Block Comment***********************
* Sean Berlin
* Write a program that calls a method to display information about CR North. * Items you might include are the name of the school, 
* number of students enrolled(look up information about CRNorth), 
* and school colors. The display should be aesthetically pleasing.
*  Your programs should continue to have an intro(), ending().
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_School
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("CR North Info", "This program displays information about CR North", ConsoleColor.Red, 70);
            CrInfo();
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
        public static void CrInfo()
        {

            Console.WriteLine("CR North has 2500 students enrolled. \nThe school colors are blue and silver. \nIt was founded in 1969. \nHit enter for ending");
            Console.ReadLine();
        }
    }    
}
