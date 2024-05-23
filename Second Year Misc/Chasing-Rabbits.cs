/******************Block Comment***********************
 * Sean Berlin
 * Program Description: A dog is chasing a rabbit. 
 * The rabbit takes three jumps in the same length of time the dog takes two jumps,
 *  but each rabbit jump covers only half of the distance of a dog jump.
 *  The rabbit was 13 rabbit jumps ahead of the dog when the dog first spotted 
 *  the rabbit and started after it. If both go in a straight line,
 *   how many more jumps will the rabbit take before the dog catches it? 
 * Your program should print out a representation of the chase 
 * Statements Required: output, loop control 
 * Sample Output: 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * D R 
 * DR 
 * DR 
 * DR 
 * DR The rabbit took 52 steps before the dog caught up 
 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasingRabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0; //start row
            int dogPos = 0;
            int rabPos = dogPos + 13;
            // Console.SetCursorPosition(rabPos, row);
            //Console.Write("R"+rabPos);
            // Console.SetCursorPosition(dogPos, row);
            //
            Console.Write("D");//Console.WriteLine("D" + dogPos);
            Console.SetCursorPosition(rabPos, row);
            Console.Write("R");
            while (rabPos >dogPos)
            {
                rabPos = rabPos + 3; // 3 spots for rabbit
                dogPos = dogPos + 4; //4 spots for rabbit
                row++;
                Console.SetCursorPosition(rabPos, row);
                Console.Write("R");
                //Console.Write("R" + rabPos);
                Console.SetCursorPosition(dogPos, row);
                Console.Write("D" );
                //Console.Write("D" + dogPos);
            }
            Console.WriteLine("\nThe rabbit took {0} steps before the dog caught up",rabPos);
            Console.ReadLine();
        }
    }
}
