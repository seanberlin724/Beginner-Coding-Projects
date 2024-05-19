/******************Block Comment***********************
 * Sean Berlin
 * Create a console or windows application called EX42_ComputerGuesses.  
 * Write code that plays a guessing game where the computer tries to guess a number
 * picked by the user.  The program asks the user to think of a secret number,
 * and then asks the user a sequence of guesses.  
 * After each guess, the user must report whether it is too high or too low or correct.
 * The computer should be able to guess in the most efficient way
 * (less than 7 times for numbers between 1 and 100)The program should count the guesses.
 * (Hint: maintain HighestPossible and LowestPossible variables,
 * and always guess midway between the two.  this is called a binary search.)
 * The console program's output should look something like this:
Console Example:
Think of a number between 1 and 100.
I know I can guess it....
Is your number 50 (correct, low, high)? h
Is your number 25 (correct, low, high)? h
Is your number 13 (correct, low, high)? l
Is your number 19 (correct, low, high)? c
I guessed your number in 4 tries.
I think I can do better.  Can I try again? no
Have a nice day.
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_ComputerGuesses
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Number Guesser", "This program will guess the number you are thinking of.", ConsoleColor.White, 80);
            Console.WriteLine("Think of a number between 1 and 100.");
            //\nIf your number is higher than the computer's guess then type \"higher\" \nIf your number is lower than the computer's guess then type \"lower\"
            int num = Convert.ToInt32(Console.ReadLine());
            int high = 100;
            int low = 1;
            int attempts = 1;
            string response = "";
            do
            {
                int guess = guesserCalculator(high, low);
                Console.WriteLine("Is your number {0} (correct, lower, higher)? ", guess);
                response = Console.ReadLine();                
                if (response == "correct")
                {
                    Console.WriteLine("I guessed your number in {0} attempts", attempts);
                }
                if (response == "higher")
                {
                    low = guess;
                }
                if (response == "lower")
                {
                    high = guess;
                }
                attempts++;
            } while (response != "correct");
            Console.ReadLine();
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
        public static int guesserCalculator(int high, int low)
        {
            return (high + low) / 2;
        }
    }
}
