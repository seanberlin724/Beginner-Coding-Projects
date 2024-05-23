/******************Block Comment***********************
 * Sean Berlin
 * Program Description: This program demonstrates the usage of the 'ref' keyword in C#.
 *                      It defines a method that swaps the values of two integer variables using 'ref' parameters.
 *                      The values of the variables before and after the swap are displayed to the user.
 * 
 * Required Statements: input, output, method definition, 'ref' keyword
 * 
 * Methods:
 * - swap: Swaps the values of two integer variables using 'ref' parameters
 * 
 * Sample Output:
 * x1 = 10
 * x2 = 5
 * After swap:
 * x1 = 5
 * x2 = 10
 * 
 * ***********************************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefDemo201920
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            int x2 = 5;
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);

            swap(ref x1, ref x2);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
            Console.ReadLine();
        }
        static void swap(ref int x1, ref int x2)
        {
            int temp = x1;  // temp = 10
            x1 = x2;       //  x1 = 5
            x2 = temp;     //  x2 = 10
        }
    }
}
