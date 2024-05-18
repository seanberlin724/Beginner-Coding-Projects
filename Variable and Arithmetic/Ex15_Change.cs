/******************Block Comment***********************
* Sean Berlin 
* Write a program that prints the number of quarters, dimes, nickels, and pennies 
* that a customer should get back as change. 
* Run your program once by performing a compile-time initialization using 92 cents for the value to be converted. 
* Go into your source code and change the 92 to 27. 
* Rerun the application.
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Change for money";
            int money = 27;
            int cents = money / 100;
            int numberOfQuarters = money / 25;
            int numberOfDimes = money % 25 / 10;
            int numberOfNickels = money % 25 % 10 / 5;
            int numberOfPennies = money % 25 % 10 % 5 / 1;
            Console.WriteLine("When your change is {0:c2} you will get back {1:f0} quarters, {2:f0} dimes, {3:f0} nickels, and {4:f0} pennies", money / 100.0, numberOfQuarters, numberOfDimes, numberOfNickels, numberOfPennies);
            Console.ReadLine();
        }
    }
}
