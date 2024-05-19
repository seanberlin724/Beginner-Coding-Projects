/******************Block Comment***********************
 * Sean Berlin
 * Create a Console Application called EX28_Counting. 
 * Write code that uses a while loop 
 * and a counter to display the number 1 through 12 each on a new line.
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x<=12)
            {
                Console.WriteLine(x+" ");
                x++;          
            }
            Console.ReadLine();
        }
    }
}
