/*      Sean Berlin     12-12-18  
 *      Demo on looping
 *              while, do...while, for and foreach
 *              
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            //this sets the title and starts the program with Looping Demo at the top
            //this should be in a method however to same time for our notes we will put it here.
            Console.Title = "Looping Demo";
            Console.WriteLine("Looping Demo");

            // Why use a loop?

            // for repetition
            // computers are fast and good at doing
            //      the same thing over and over
            //      without mistakes


            //here are 4 different ways to loop your code
            //       1. while, 2. do...while, 3. for and 4. foreach


            // While
            Console.WriteLine();
            Console.WriteLine("****************   The While loop   ****************");

            // while the condition is true do the stuff
            // in the {}
            //              while(condition)
            //              {
            //                    statements here; 
            //              }
            // example of the while loop:

            int x = 10; //if x > 20 this loop does NOT run at all
            while (x<=20)
            {
                Console.Write(x + " ");
                //we need to make some kind of counter or
                // sentinel that will change "while" condition
                x = x + 2; //+2 so it stops
            }

            //////////////////////////////////////////
            // Note: a while loop may not run at all
            ////////////////////////////////////////////
            // example of while loop:

            Console.WriteLine();
            string tester = "yes";
            while (tester.ToLower() == "yes" || tester =="yep")
            {
                //do something 
                Console.Write("what is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello nice to meet you" + name + ".");

                //modify tester so we can get the loop to stop
                Console.WriteLine("Would you like to run this again?");
                tester = Console.ReadLine();
            }
            ////////////////////////////////////////////////////////
            //             the     do...while   loop
            ////////////////////////////////////////////////////////////

            Console.WriteLine();
            Console.WriteLine("*************      The do... while loop     *************");
            // example of do while loop:
            int y = 2;
            do
            {
                Console.Write(y + " ");
                y = y * 2;
            } while (y < 2000);


            do
            {
                Console.WriteLine("Run this loop and do some stuff...");
                //intro();
                //int r = getRadius();
                //double area = getArea(r);
                //display(r, Area);
                Console.WriteLine("Run again?");
                tester = Console.ReadLine();
            } while (tester.ToLower() == "yes");

            //checks condition after and will runb atleast once
            //better to wrap in do loop
            //////////////////////////////////
            // Note: The do loop will run atleast one time!!!
            //////////////////////////////////
            /////////////////////////////////////////////////////////////
            //              the     for     loop  (most common) 
            /////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("*************         The for  Loop         **************");
            // for loops are used when you know
            // how many times you need to run your loop

            //   Examples of for loops: 
            Console.WriteLine();
            for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            //mults of 5
            for (int i = 0; i < 100; i+=5)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            //from 20 to -5 by 3
            for (int i = 20; i >= -5; i-=3)
            {
                Console.WriteLine(i + " ");
            }

            //from 52 to 108 mult of 3 or 5
            for (int i = 52; i < 108; i++)
            {
                if (i % 3 == 0 || i%5==0)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < 30; i++)
            {
                if (i%3==0)
                {
                    Console.Write("Bizz");
                }
                else if (i%7 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

            //what is the sum of the number between 45 and 2034 that are multiples of 3
            int sum = 0;
            for (int i = 45; i <= 2034; i++)
            {
                if (i%3==0)
                {
                    sum = sum = i;
                }
            }

            ////////////////////////////////////////////
            //              foreach (arrays)
            /////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("*************  The foreach at a later date  **************");
            Console.WriteLine();
            Console.WriteLine("*************    using loops to find sums    **************");

            // examples on sums:
            sum = 0;
            for (int i = 1; i <= 1024; i*=2) //i*2 is what you want to be done to i
            {
                sum = sum + i;  //this is where you want each new line or new next m=number to beto be
            }
            Console.WriteLine("The sume is:" +sum);

            sum = 0;
            for (int i = 123; i <= 234; i++)
            {
                if (i%3==0)
                {
                    sum = sum + i;
                }             
            }
            Console.WriteLine("The sum is:" +sum);
            sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i%3==0 ||  i%7==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum of the mults of 3 or mults of 7 is:" +sum);
            sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum of the mults of 3 AND mults of 7 is:" +sum);
            ///////////////////   the ending       
            ////// This stuff is the ending normally it would be in a method
            Console.SetCursorPosition(30, 25);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hit anykey to end.");
            Console.ReadKey();
        }// end of main
    }
}
