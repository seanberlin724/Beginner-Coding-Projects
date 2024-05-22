/******************Block Comment***********************
 * Sean Berlin
 * Program Description: This program prompts the user for the first day
 * of the month and the number of days in the month, and then prints out
 * a calendar for that month. The calendar displays days in a week format
 * starting from the specified first day.
 * 
 * Required Statements: input, output, loop control, decision making
 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender_Try_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First day of the month:");
            int firstDayOfMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of Days in the month:");
            int numOfDaysInMonth = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Sunday Monday Tuesday Thursday Friday Saturday Sunday");
            int counter = firstDayOfMonth + 1;
            int magicNumber = 7 - firstDayOfMonth;
            int secondMagicNumber = 14 - firstDayOfMonth;
            int thirdMagicNumber = 21 - firstDayOfMonth;
            int fourthMagicNumber = 28 - firstDayOfMonth;
            int fifthMagicNumber = 31 - firstDayOfMonth;
            //whatever i = "this number" needs to be special. needs to be 1 greater than first day of month
            int i = 1 + (8 - firstDayOfMonth);
            for (i = 1 - firstDayOfMonth; i <= numOfDaysInMonth; i++)
            {

                if (i < 8 - firstDayOfMonth)//1-7
                {
                    Console.Write("{0}\t", i);
                }
                if (i == 8 - firstDayOfMonth)
                {
                    Console.WriteLine("");
                }
                if (i > 7 - firstDayOfMonth && i < 15 - firstDayOfMonth) //8-14
                {
                    Console.Write("{0}\t", i);
                }
                if (i == 15 - firstDayOfMonth)
                {
                    Console.WriteLine("");
                }
                if (i > 14 - firstDayOfMonth && i < 22 - firstDayOfMonth)//15-21
                {
                    Console.Write("{0}\t", i);
                }
                if (i == 22 - firstDayOfMonth)
                {
                    Console.WriteLine("");
                }
                if (i > 21 - firstDayOfMonth && i < 29 - firstDayOfMonth)//22-28
                {
                    Console.Write("{0}\t", i);
                }
                if (i == 29 - firstDayOfMonth)
                {
                    Console.WriteLine("");
                }
                if (i > 28 - firstDayOfMonth && i < 32)//29-31
                {
                    Console.Write("{0}\t", i);
                }
            }
            Console.ReadLine();
        }
    }
}

