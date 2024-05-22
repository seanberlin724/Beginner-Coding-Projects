/******************Block Comment***********************
 * Sean Berlin
 * Create a Die class. Each die has 2 instance variables (number of sides, current side).
 * Each die should have the ability to roll() to change its current side value and return that value to the client that uses it.
 * Next, make a client that creates a die object and tests it by rolling it 20 times. Note: we do this to ensure that our object is working as planned.
 * Finally, use the die class to make a second client that rolls a pair of dice objects 90000 times and displays the number amount of times a sum of 2 or 12 was rolled.
 * (Note: this number should be very close to 5000). You may wish to experiment with different sums to see if they are consistent with the theoretical probability.
 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Die_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Random newRandy = new Random();
            int sumOfTwoOrTwelveCounter = 0;
            int sumOfDice = 0;
            Die myDie1 = new Die(askNumOfSides(), newRandy);
            for (int i = 0; i <= 20; i++)
            {
                myDie1.roll();
                Console.WriteLine("Roll result:" +myDie1.CurrentSide);
            }
            Console.WriteLine("Hit enter to perform second part");
            Console.ReadLine();
            Console.Clear();
            Die myDie2 = new Die(askNumOfSides(), newRandy);
            Die myDie3 = new Die (askNumOfSides(), newRandy);
            for (int i = 0; i < 90000; i++)
            {
                myDie2.roll();
                myDie3.roll();
                sumOfDice = myDie2.roll() + myDie3.roll();
                if (sumOfDice == 2 || sumOfDice == 12)
                {
                    sumOfTwoOrTwelveCounter++;
                }
            }
           // Console.WriteLine("Rolled a 1: "+rolledOneCounter);
            Console.WriteLine("You rolled the sum of a 2 or 12 "+sumOfTwoOrTwelveCounter +" times");
            Console.ReadLine();
        }
        public static int askNumOfSides()
        {
            Console.WriteLine("How many sides do you want your die to have? ");
            int numOfSides = Convert.ToInt32(Console.ReadLine());
            return numOfSides;
        }
    }
}
