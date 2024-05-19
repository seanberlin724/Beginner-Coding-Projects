/******************Block Comment***********************
 * Sean Berlin
 * Create a Console Application called Ex29_Counting2. 
 * Write code that uses a for loop that displays the numbers from 2 to 20 by twos, i.e., 2,4,6,8,10, etc. 
 * (hint use Number +=2 as the increment). Now have your program modify the count by 2’s backwards. 
 * Show both and ask the user if they would like to see it again.
 *  Remember appropriate methods and variable names. Comment, Comment, COMMENT!!!
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29_Counting2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tester = "yes";
            do { 
            
                Console.WriteLine("Numbers from 2 to 20 Counting by 2s");
                int sum = 0;
                for (int i = 2; i <= 20; i += 2)
                {
                    sum = i + 1;
                    Console.WriteLine(i + " ");
                }

                Console.WriteLine("Numbers from 20 to 2 Counting by 2s");
                int sum2 = 0;
                for (int i = 20; i >= 2; i -= 2)
                {
                    sum2 = i + 1;
                    Console.WriteLine(i + " ");
                }      
                Console.WriteLine("Do you want to run this again?");
                tester = Console.ReadLine();
                }while(tester.ToLower() == "yes");
        }        
    }
}
