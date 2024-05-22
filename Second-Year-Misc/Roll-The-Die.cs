/******************Block Comment***********************
 * Sean Berlin
 * Create a method Roll() that simulates a Die being rolled. Use this method to 
 * Fill an array of values with the a random roll of the Die.
 *  Let the user enter the number of roll to be collected in the array.
 *  Then use a self created PrintArray(int[] x)
 *  method to print that array of dice rolls.
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTheDie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rolls of the die do you want");
            int numOfRolls = Convert.ToInt32(Console.ReadLine());
            int [] storeDie= Roll(numOfRolls);
            Console.WriteLine("Your die results are:");
            PrintArray(storeDie,numOfRolls);//call method to print array results
            Console.ReadLine();
        }
        public static Random rnd1 = new Random(); //for random numbers
        public static int [] Roll(int numOfRolls) //creates storeDie array that stores all elements with radnom rolls//should return storeDie array
        {
            int[] storeDie = new int[numOfRolls];
            for (int i = 0; i < storeDie.Length; i++)
            {
                int roll1 = rnd1.Next(1, 7);
                storeDie[i] = roll1;
            }
            return storeDie;      
        }
        public static void PrintArray(int [] storeDie, int numOfRolls)//prints results of rolled die, each on separate line
        {
            for (int i = 0; i < numOfRolls; i++)
            {
                Console.WriteLine("{0}",storeDie[i]);
            }
        }
    }
}
