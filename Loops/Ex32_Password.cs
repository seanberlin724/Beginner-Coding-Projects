/******************Block Comment***********************
* Sean Berlin
* Create a Console Application called Ex32_Password. Write a simple “password” program. 
* Have the user repeatedly enter a password until the secret word “Mela” is entered. 
* Further add an if statement that outputs a message for all incorrect tries.
* Finally only allow 5 tries, and remember to display a “password warning” message.
* */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Password Program", "This is a password program", ConsoleColor.Green, 72);
            Console.WriteLine("Please enter the correct password ");
            string tester = Console.ReadLine();
            do
            {
                if (tester == "mela")
                {
                    Console.WriteLine("You have entered the correct password. \nHave a nice day");
                    tester = "no";
                    ending();
                }
                if (tester != "mela")
                {
                    Console.WriteLine("You have entered the wrong password.\nYou have four more tries");
                    tester = Console.ReadLine();
                    if (tester != "mela")
                    {
                        Console.WriteLine("You have entered the wrong password. \nYou have three more tries");
                        tester = Console.ReadLine();
                        if (tester != "mela")
                        {
                            Console.WriteLine("You have entered the wrong password. \nYou have two more tries");
                            tester = Console.ReadLine();
                            if (tester != "mela")
                            {
                                Console.WriteLine("You have entered the wrong password. \nYou have one more try");
                                tester = Console.ReadLine();
                                if (tester != "mela")
                                {
                                    Console.WriteLine("You have enterd the wrong password. \nExit the program and try again");
                                }
                            }
                        }
                    }
                }
            } while (tester.ToLower() == "mela");
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

