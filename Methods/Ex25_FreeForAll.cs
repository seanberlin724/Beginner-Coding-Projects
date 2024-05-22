/******************Block Comment***********************
 * Sean Berlin
 * This is a change to be creative and make an interesting program of our own. 
 * Create EX25_FreeForAll as an interesting program that uses methods.
 * Use your imagination. This is your chance to make something cool. 
 * Use appropriate variable/method names and don’t forget to comment your code.
 * The purpose of this program calculates the true shooting percentage from collecting user input.
 * *****************************
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_FreeForAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("True Shooting Percentage Calculator", "This program will calculate your true shooting percentage. \nTrue shooting percentage is an analytic used in basketball. \nThe analytic incorporates two-pointers, three-pointers, \nand free throws into its formula. \nIn others words, it considers the number of points a player \nscored relative to the shooting possessions he used.", ConsoleColor.Green, 80);
            double pointsTotal = pointsCollector();
            double fieldGoalTotal = fieldGoalCollector();
            double freeThrowTotal = freeThrowCollector();
            double calculatedPercentage = calculate(pointsTotal, fieldGoalTotal, freeThrowTotal);
            displayData(pointsTotal, fieldGoalTotal, freeThrowTotal, calculatedPercentage);
            ending();

        }
        public static void Intro(string title, string discription, ConsoleColor myColor, int myWidth)
        {
            Console.Title = title;
            Console.BackgroundColor = myColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = myWidth;
            Console.WindowHeight = 20;
            Console.Clear();
            Console.WriteLine("This is the Greatest Into ever!!");
            Console.WriteLine(discription);
        }
        public static double pointsCollector()
        {
            Console.WriteLine("Please enter your total points scored:");
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public static double fieldGoalCollector()
        {
            Console.WriteLine("Please enter the amount of field goals you attempted:");
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public static double freeThrowCollector()
        {
            Console.WriteLine("Please enter the amount of free throws you attempted:");
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public static double calculate(double pointsTotal, double fieldGoalTotal, double freeThrowTotal)
        {
            //double x = (pointsTotal / (2 * (fieldGoalTotal + 0.44 * freeThrowTotal)) * 100);
            double x = pointsTotal / (2 * (fieldGoalTotal + 0.44 * freeThrowTotal));
            return x;
        }
        public static void displayData(double pointsTotal, double fieldGoalTotal, double freeThrowTotal, double calculatedPercentage)
        {
            Console.WriteLine("If you scored {0} points and attempted {1} field goals and {2} free throws \nthen your true shooting percentage is {3:p}", pointsTotal, fieldGoalTotal, freeThrowTotal, calculatedPercentage);
        }
        public static void ending()
        {
            Console.SetCursorPosition(15, 20);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();
        }
    }
}


