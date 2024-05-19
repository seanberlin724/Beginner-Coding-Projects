/******************Block Comment***********************
* Sean Berlin
* Create a console application called EX22_Time with several appropriate methods. 
* {introduction(), collectData(), calculate(), displayData(),ending()} 
* Write code that allows the user to enter a time in minutes and 
* then displays the time in hours:minutes format.
* Example:
* Enter the number of minutes: 327
* 327 minutes is 5 hours and 27 minutes(5:27).
* NOTE: Be sure to consider times where the number of minutes left over is fewer than 10. 
* (Hint: use the modulus(%) operator.)
 * *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_Time_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Minute Converter", "This program converts minutes to hours and minutes", ConsoleColor.Blue, 70);
            int minutes = collectData();
            int x = minutes;
            int hours = calculate(minutes);
            int remainderMinutes =  differentcalculate(minutes);
            int remainderMinutesTens = tenOfMinutes(minutes);
            displayData(minutes, remainderMinutes, remainderMinutesTens, hours);
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
        public static int collectData()
        {
            Console.WriteLine("Enter the amount of minutes");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int calculate(int minutes)
        {
            int calcHours = minutes / 60; 
            return calcHours;
        }
        public static int differentcalculate(int minutes)
        {
            int calcMinutes = (minutes % 60) % 10;
            return calcMinutes;
        }

        public static int tenOfMinutes(int minutes)
        {
            int remainderTensOfMinutes = (minutes % 60) / 10;
            return remainderTensOfMinutes;
        }
        public static void displayData(int minutes, int calcMinutes, int remainderTensOfMinutes, int calcHours)
        {
            Console.WriteLine("{0} minutes is {1} hour and {2}{3} minute({1}:{2}{3})", minutes, calcHours, remainderTensOfMinutes,calcMinutes);
            // Console.WriteLine("{0} minutes is {1} hour(s) and {2} minute(s", minutes, calculate(calcMinutes, calcHours), calculate(calcMinutes,calcHours));
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

