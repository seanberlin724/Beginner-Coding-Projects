/******************Block Comment***********************
 * Sean Berlin
 * This program demonstrates the Ulam Hypothesis for numbers 1 through 25
 * Program Description: The mathematician Stanislau Ulam of the University 
 * of Colorado hypothesized that any positive integer would always converge to 
 * 1 if treated as follows 

  If it is odd, multiply it by three and add 1 If it is even, divide it by 2 
The procedure is then applied to the result of each calculation

 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulam_Hypothesis
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 1;
            int num = 1;
            num = baseNum;
            for (baseNum = 1; baseNum <= 25; baseNum++)
            {
                Console.Write("\n" + baseNum + ":");
                num = baseNum;
                do
                {
                    if (num % 2 == 0)
                    {
                        num /= 2;
                        Console.Write(" " + num);
                    }
                    else
                    {
                        num = 3 * num + 1;
                        Console.Write(" " + num);
                    }

                } while (num != 1);
                num = baseNum;
                //Console.Read();
            }
            Console.ReadLine();
        }
    }
}


