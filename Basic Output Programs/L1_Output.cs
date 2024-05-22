/******************Block Comment***********************
 * Sean Berlin
 * Notes for this section of programs.
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  above are libraries for different functions

//  this is an in line comment

namespace L1_Output
{
    class Program
    {
        static void Main(string[] args) //This is where all programs start "the Main Method"
        {
            Console.Title = "My Output Notes";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = 60;
            Console.WindowHeight = 30;
           

            //Send a string  to the console
            Console.WriteLine("My name is Sean."); //note each statement needs a ; at the end

            // examples of printing ' " \
            Console.WriteLine("My name is...");
            Console.WriteLine("\"Slim\""); // "Slim"  / "="
            Console.WriteLine("I can\'t");  // "an't"\'=';
            Console.WriteLine("http:\\\\www.crsd.org"); // //=/
          //Console.WriteLine("\a");  // default alert
            Console.WriteLine("Col1\tCol2\tcole3");  // \\=\
            Console.WriteLine("Joe\tken\tSue");
            //new line  /n
            Console.WriteLine("This\nis\nnew\nline");
            /*   This
             *   is
             *   a
             *   new
             *   line
             *   
             */

            Console.Beep(300, 1200);
            // first freq, time in milliseconds  

            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();  // waits for a keyboard
            Console.Clear();


            // Lets make a flag!!
            // Fun with Flags

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" * * * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                   ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("* * * * * * * * * * ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                   ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" * * * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                   ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("* * * * * * * * * * ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                   ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" * * * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                       ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                       ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                       ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                       ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                       ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                       ");
            Console.ReadLine();
            Console.ReadLine();  // waits for a keyboard enter
        }
    }
}
