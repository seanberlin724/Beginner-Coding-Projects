/******************Block Comment***********************
* Sean Berlin
* This one should look familiar. 
* Write a program called EX24_ChangePlease that prints the number of
* dollars, quarters, dimes, nickels, and pennies the a customer should get back as change.
* The user should enter the cost of the item and the amount collected. 
* Calls to separate self created methods should make the calculations for the 
* dollars, quarters, dimes, nickels and pennies. 
* Display results in an pleasing manner.
* Example:
* Please enter the cost of the item: 21.34
* Please enter the amount tendered: 25.00
* The change to be returned is $3.66.
* 3 dollar(s)
* 2 quarter(s)
* 1 dime(s)
* 1 nickel(s)
* 1 penny(s)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_ChangePlease_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Change Converter", "This program will display the change given", ConsoleColor.Green, 70);
            decimal cost = CostCollector();
            decimal amountPaid = AmountCollector();
            int amountDifference = DifferenceCollector(cost, amountPaid);
            int calcDollars = Dollars(amountDifference);
            int calcQuarters = Quarters(amountDifference);
            int calcDimes = Dimes(amountDifference);
            int calcNickels = Nickels(amountDifference);
            int calcPennies = Pennies(amountDifference);
            displayResults(calcDollars, calcQuarters, calcDimes, calcNickels, calcPennies);
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
        public static decimal CostCollector()
        {
            Console.WriteLine("Please enter the cost of the item:");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            return x;
        }
        public static decimal AmountCollector()
        {
            Console.WriteLine("Please enter the amount tendered:");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            return x;
        }
        public static int DifferenceCollector(decimal cost, decimal amountPaid)
        { 
            int change = (int) ((amountPaid - cost) * 100);
            Console.WriteLine("The change to be returned is {0:c2}", change / 100.0);
            return change;
        }
        public static int Dollars(int amountDifference)
        {
            return amountDifference / 100;
        }
        public static int Quarters(int amountDifference)
        {
            return amountDifference %100 / 25;
        }
        public static int Dimes(int amountDifference)
        {
            return amountDifference %100 % 25 / 10;
        }
        public static int Nickels(int amountDifference)
        {
            return amountDifference %100 %25 %10 /5;
        }
        public static int Pennies(int amountDifference)
        {
            return amountDifference %100 %25 %10 %5 /1;
        }
        public static void displayResults(int calcDollars, int calcQuarters, int calcDimes, int calcNickels, int calcPennies)
        {
            Console.WriteLine("Your change is {0} dollars, \n{1} quarters, \n{2} dimes, \n{3} nickels, \nand {4} pennies", calcDollars, calcQuarters, calcDimes, calcNickels, calcPennies);
        }
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();

        }
    }
}

