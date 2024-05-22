/******************Block Comment***********************
 * Sean Berlin
 * Slotz
 * Create an application (form or console) called EX43_Slotz. 
 * Write code that acts as a simple "slot machine."  
 * The user starts with 100 tokens, and with each "pull" of the handle, loses 1 token.  
 * The computer "spins" the three wheels, each consisting of the number 1, 2 and 3. 
 * If all three numbers are 1, the user gets 4 tokens; if all three are 2,
 * the user gets 8 tokens: if all three are 3, the user gets 12 tokens.
 * Output for console app should look similar to:
		   		You have 100 tokens.  Pull?   Y
					[1] [3] [2]
					You lost.
					You have 99 tokens.  Pull?   Y
					[2] [2] [2]
					You won 8 tokens!
					You have 106 tokens.  Pull?    N
					Cash out 106 tokens.... Thanks for playing!
 * Remember random numbers?  To create a random number...
 * Random myrandom = new Random();
 * int number1 = myrandom.Next(1,3); //this will give you
 * //random ints from 1 to 2
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX43_Slots
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            int tokenNumber = 100;
            Console.WriteLine("You have {0} tokens. Do you want to pull the slot machine?", tokenNumber);
            response = Console.ReadLine();
            while(response.ToLower() == "yes")
            {
                response = "";
                tokenNumber = pull(tokenNumber);
                int wheel1 = wheel1Finder(); int wheel2 = wheel1Finder(); int wheel3 = wheel1Finder();
                if (wheel1 == 1 && wheel2 == 1 && wheel3 == 1)
                {
                    Console.WriteLine("You won");
                    tokenNumber = allOnes(tokenNumber);
                }
                if (wheel1 == 2 && wheel2 == 2 && wheel3 == 2)
                {
                    Console.WriteLine("You won");
                    tokenNumber = allTwos(tokenNumber);
                }
                if (wheel1 == 3 && wheel2 == 3 && wheel3 == 3)
                {
                    Console.WriteLine("You won");
                    tokenNumber = allThrees(tokenNumber);
                }
                Console.WriteLine(" {0}\t{1}\t{2}", wheel1, wheel2, wheel3);
                Console.WriteLine("You have {0} tokens. Do you want to pull the slot machine?", tokenNumber);
                response = Console.ReadLine();
            } while (response.ToLower() == "yes");
            Console.WriteLine("Cash out {0} tokens. Thank you for playing",tokenNumber);
            Console.ReadLine();
        }
        public static Random rnd1 = new Random();
        public static int pull(int tokenNumber)
        {
            return tokenNumber - 1;
        }
        public static int wheel1Finder()
        {    
            int wheel1 = rnd1.Next(1,4);
            return wheel1;
        }
        public static int allOnes(int tokenNumber)
        {
            return tokenNumber + 4;
        }
        public static int allTwos(int tokenNumber)
        {
            return tokenNumber + 8;
        }
        public static int allThrees(int tokenNumber)
        {
            return tokenNumber + 12;
        }
     
    }
}
