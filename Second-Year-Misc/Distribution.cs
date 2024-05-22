/******************Block Comment***********************
 * Sean Berlin
 * Program Description: Reuse the Roll() method to create another method that fills an array called diceSum.
 * The idea is to simulate the rolling of 2 dice several times (let's say 100 but could be more).
 * Display the sum of the dice as a histogram.
 * 
 * Possible outcome for 51 sums:
 * 
 *                       x
 *           x       x   x
 *       x   x   x   x   x   x
 *       x   x   x   x   x   x   x
 *   x   x   x   x   x   x   x   x   x
 *   x   x   x   x   x   x   x   x   x   x
 * x x x x x x x x x x x x x x x x x x x x
 * x x x x x x x x x x x x x x x x x x x x x
 * ___________________________________________________
 * 2  3  4  5  6  7  8  9  10  11  12
 * 
 * Hint: The data above is stored in an array defined by int[] diceSum = new int[11];
 * The idea is to keep track of the sums not the rolls.
 * The values stored in diceSum[5] represent the number of times the two dice rolled a sum of 7.
 * 
 * diceSum[0] represents the sum of 2
 * diceSum[1] represents the sum of 3
 * ...
 * diceSum[9] represents the sum of 11
 * diceSum[10] represents the sum of 12
 * 
 * SO in general…
 * 
 * diceSum[theSum - 2] represents theSum
 * 
 * for (int i = 0; i < numberOfRollsRolled; i++)
 * {
 *     diceSum[(die1Roll + die2Roll - 2)]++;
 * }
 * 
 * Methods:
 * - Method that makes a roll of a die (6 sides)
 * - Method that rolls the die twice and puts the sum in an array
 * - Method to print an array
 * - Method that makes the distribution array
 * - Print a number of '*' for example print("*", 10, 10, 20)
 *  symbol, x, y, amount of times
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theRolls = new int[51];
            theRolls = getSums(theRolls.Length);
          
            //printIntArray(theRolls);
            int[] theDistribution = new int[11];
            theDistribution = makeDistribution(theRolls);
            displayDistribution(theDistribution);
          
            //printIntArray(theDistribution);
            printAsterisks("*", 5, 18, theDistribution[0]); //before was myDistrobution
            Console.ReadLine();
        }

        public static int rollDie(int sides, Random x)
        {
            //int roll = x.Next(1, sides + 1);//will give sides 1-6 if sides is 6. Same as (1,7)
            return x.Next(1, sides + 1);
        }
        public static int[] getSums(int numberOfRolls)//array that holds sums
        {
            Random myRandom = new Random();
            int[] myRollSums = new int[numberOfRolls];
            for (int i = 0; i < myRollSums.Length; i++)
            {
                myRollSums[i] = rollDie(6, myRandom) + rollDie(6, myRandom);
            }
            return myRollSums;
        }
        public static void printIntArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");//print one element at a time
            }
        }
        public static int[] makeDistribution(int[] theRolls)
        {
            int[] Distribution = new int[11];
            for (int i = 0; i < theRolls.Length; i++)//add 1 t
            {
                Distribution[theRolls[i] - 2]++;
            }
            return Distribution;
        }
        public static void displayDistribution(int[] myDistribution) //sending it theDistribution
        {
            int x = 5;
            int y = 20;//15
            Console.SetCursorPosition(x, y);
            for (int i = 2; i < 13; i++)
            {
                Console.Write(i + "   ");
            }
            x = 4; y = 19;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < 46; i++)
            {
                Console.Write("-");
            }
            x = 5; y = 18;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < myDistribution.Length; i++)
            {
                if (i >= 8)
                {
                    printAsterisks("*", x, y, myDistribution[i]);
                    x += 5;
                }
                else
                {
                    printAsterisks("*", x, y, myDistribution[i]);
                    x += 4;//3

                    //Console.Write(myDistribution[i] + "  ");
                }
            }
        }
        public static void printAsterisks(string c, int x, int y, int myDistribution)//, int[] myDistribution
        {
            for (int i = 0; i < myDistribution; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("{0}", c);
                y--;
            }
        }
    }
}



