/******************Block Comment***********************
 * Sean Berlin
 * Program Description: Write a program that accepts a number of rows between 0 and 10.
 *  
 * Produce a multiplication triangle of n rows. For each row contains entries
 * up to its row size (i.e., row 3 will have the values 1X3, 2X3, 3X3, row 4 will have the values 1X4, 2X4, 3X4, 4X4), 
 * Statements Required: input, output, loop control 
 * Sample Output: 
 * Enter # of rows 6 
 * The multiplication triangle: 
 * 24 
 * 3 6 9 12 15 18 
 * 4 8 12 16 20 24 
 * 5 10 15 20 25 30 
 * 6 12 18 24 30 36 
 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bermuda_Triangle___Better
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("The multiplication triangle:");
           
            Console.WriteLine("Enter number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {        
              for (int j =1; j < i+1; j++)
              {
                int temp = j * i;
                Console.Write(" "+temp);
              }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
